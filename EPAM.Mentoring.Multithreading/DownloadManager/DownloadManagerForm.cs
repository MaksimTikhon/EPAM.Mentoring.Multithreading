using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
	public partial class DownloadManagerForm : Form
	{
		private string pSource;
		private string pDestination;
		private string[] pFiles;
		private CancellationTokenSource pCancellationTokenSource;

		private string sSource;
		private string sDestination;
		private string[] sFiles;
		private CancellationTokenSource sCancellationTokenSource;

		public DownloadManagerForm()
		{
			InitializeComponent();
		}

		#region Parallel Processing

		private void PSourceButton_Click(object sender, EventArgs e)
		{
			if (GetDirectory(out pSource))
			{
				PSourceTextBox.Text = pSource;

				pFiles = Directory.GetFiles(pSource);
				PDataGridView.Rows.Clear();
				foreach (var file in pFiles)
				{
					PDataGridView.Rows.Add(Path.GetFileName(file), "Waiting");
				}

				if (Directory.Exists(pSource) && Directory.Exists(pDestination))
				{
					PStartButton.Enabled = true;
				}
			}
		}

		private void PDestinationButton_Click(object sender, EventArgs e)
		{
			if (GetDirectory(out pDestination))
			{
				PDestinationTextBox.Text = pDestination;

				if (Directory.Exists(pSource) && Directory.Exists(pDestination))
				{
					PStartButton.Enabled = true;
				}
			}
		}

		private async void PStartButton_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(pSource))
			{
				MessageBox.Show("Source directory doesn't exist");
				return;
			}
			else if (pSource == sSource)
			{
				MessageBox.Show("Sources should be differnt");
				return;
			}

			if (!Directory.Exists(pDestination))
			{
				MessageBox.Show("Source directory doesn't exist");
				return;
			}

			PSourceButton.Enabled = false;
			PDestinationButton.Enabled = false;
			PStartButton.Enabled = false;
			PCancelButton.Enabled = true;

			pCancellationTokenSource = new CancellationTokenSource();
			try
			{
				await ParallelProcessFilesAsync(pCancellationTokenSource.Token);
			}
			catch (OperationCanceledException)
			{
				for (int i = 0; i < PDataGridView.Rows.Count; i++)
				{
					var status = PDataGridView.Rows[i].Cells[1].Value.ToString();
					if (status != "Downloaded")
					{
						PDataGridView.Rows[i].Cells[1].Value = "Canceled";
					}
				}
			}
			catch (Exception)
			{
				for (int i = 0; i < PDataGridView.Rows.Count; i++)
				{
					PDataGridView.Rows[i].Cells[1].Value = "Failed";
				}
			}

			pCancellationTokenSource = null;
			PSourceButton.Enabled = true;
			PDestinationButton.Enabled = true;
			PCancelButton.Enabled = false;
		}

		private void PCancelButton_Click(object sender, EventArgs e)
		{
			PSourceButton.Enabled = true;
			PDestinationButton.Enabled = true;
			PStartButton.Enabled = true;
			PCancelButton.Enabled = false;

			if (pCancellationTokenSource != null)
			{
				pCancellationTokenSource.Cancel();
			}
		}

		private async Task ParallelProcessFilesAsync(CancellationToken cancellationToken)
		{
			Task[] tasks = new Task[pFiles.Length];
			Action<object> Copy = x => {
				CopyFile((int)x, pDestination, cancellationToken);
			};

			for (int i = 0; i < pFiles.Length; i++)
			{
				PDataGridView.Rows[i].Cells[1].Value = "In Progress";

				tasks[i] = new Task(Copy, i, cancellationToken);
				tasks[i].Start();
			}

			await Task.WhenAll(tasks);
		}

		#endregion


		#region Sequential Processing

		private void SSourceButton_Click(object sender, EventArgs e)
		{
			if (GetDirectory(out sSource))
			{
				SSourceTextBox.Text = sSource;

				sFiles = Directory.GetFiles(sSource);
				SDataGridView.Rows.Clear();
				foreach (var file in sFiles)
				{
					SDataGridView.Rows.Add(Path.GetFileName(file), "Waiting");
				}

				if (Directory.Exists(sSource) && Directory.Exists(sDestination))
				{
					SStartButton.Enabled = true;
				}
			}
		}

		private void SDestinationButton_Click(object sender, EventArgs e)
		{
			if (GetDirectory(out sDestination))
			{
				SDestinationTextBox.Text = sDestination;

				if (Directory.Exists(sSource) && Directory.Exists(sDestination))
				{
					SStartButton.Enabled = true;
				}
			}
		}

		private async void SStartButton_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(sSource))
			{
				MessageBox.Show("Source directory doesn't exist");
				return;
			}
			else if (pSource == sSource)
			{
				MessageBox.Show("Sources should be differnt");
				return;
			}

			if (!Directory.Exists(sDestination))
			{
				MessageBox.Show("Source directory doesn't exist");
				return;
			}

			SSourceButton.Enabled = false;
			SDestinationButton.Enabled = false;
			SStartButton.Enabled = false;
			SCancelButton.Enabled = true;

			sCancellationTokenSource = new CancellationTokenSource();
			try
			{
				await SequentialProcessFilesAsync(sCancellationTokenSource.Token);
			}
			catch (OperationCanceledException)
			{
				for (int i = 0; i < SDataGridView.Rows.Count; i++)
				{
					var status = SDataGridView.Rows[i].Cells[1].Value.ToString();
					if (status != "Downloaded")
					{
						SDataGridView.Rows[i].Cells[1].Value = "Canceled";
					}
				}
			}
			catch (Exception)
			{
				for (int i = 0; i < SDataGridView.Rows.Count; i++)
				{
					SDataGridView.Rows[i].Cells[1].Value = "Failed";
				}
			}

			sCancellationTokenSource = null;
			SSourceButton.Enabled = true;
			SDestinationButton.Enabled = true;
			SCancelButton.Enabled = false;
		}

		private void SCancelButton_Click(object sender, EventArgs e)
		{
			SSourceButton.Enabled = true;
			SDestinationButton.Enabled = true;
			SStartButton.Enabled = true;
			SCancelButton.Enabled = false;

			if (sCancellationTokenSource != null)
			{
				sCancellationTokenSource.Cancel();
			}
		}

		private async Task SequentialProcessFilesAsync(CancellationToken cancellationToken)
		{
			Action Copy = () => {
				for (int i = 0; i < sFiles.Length; i++)
				{
					SDataGridView.Rows[i].Cells[1].Value = "In Progress";
					CopyFile(i, sDestination, cancellationToken, false);
				}
			};

			Task task = new Task(Copy, cancellationToken);
			task.Start();

			await task;
		}

		#endregion

		private void CopyFile(int index, string destinationDirectory, CancellationToken cancellationToken, bool parallelMode = true)
		{
			var buffer = new byte[1024];
			var file = parallelMode ? pFiles[index] : sFiles[index];

			int bytesRead;
			using (Stream source = File.Open(file, FileMode.Open, FileAccess.Read))
			{
				using (Stream destination = File.Create(Path.Combine(destinationDirectory, Path.GetFileName(file))))
				{
					while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
					{
						destination.Write(buffer, 0, bytesRead);
						cancellationToken.ThrowIfCancellationRequested();
					}
				}
			}

			if (parallelMode)
			{
				PDataGridView.Rows[index].Cells[1].Value = "Downloaded";
			}
			else
			{
				SDataGridView.Rows[index].Cells[1].Value = "Downloaded";
			}
		}

		private bool GetDirectory(out string path)
		{
			path = string.Empty;
			DialogResult result = FolderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				path = FolderBrowserDialog.SelectedPath;

				return true;
			}

			return false;
		}
	}
}
