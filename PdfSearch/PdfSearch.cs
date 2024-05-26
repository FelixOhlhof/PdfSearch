using System.Diagnostics;
using UglyToad.PdfPig.Content;

namespace PdfSearch
{
  public partial class PdfSearch : Form
  {
    public PdfSearch()
    {
      InitializeComponent();
    }

    private void buttonChooseFolder_Click(object sender, EventArgs e)
    {
      try
      {
        using (var fbd = new FolderBrowserDialog())
        {
          DialogResult result = fbd.ShowDialog();

          if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
          {
            textBoxPath.Text = fbd.SelectedPath;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void buttonRunSearch_Click(object sender, EventArgs e)
    {
      if (textBoxPath.Text == "")
      {
        MessageBox.Show("Select path first!");
        return;
      }

      if (textBoxSearchTerm.Text == "")
      {
        MessageBox.Show("Select search string first!");
        return;
      }

      dataGridViewResults.Rows.Clear();

      string[] pdfFiles = Directory.GetFiles(textBoxPath.Text, "*.pdf", SearchOption.TopDirectoryOnly);

      foreach (string pdfFile in pdfFiles)
      {
        int occurrences = 0;

        try
        {
          using (var stream = File.OpenRead(pdfFile))
          using (UglyToad.PdfPig.PdfDocument document = UglyToad.PdfPig.PdfDocument.Open(stream))
          {
            IEnumerable<Page> pages = document.GetPages();

            foreach (Page page in pages)
            {
              var words = page.GetWords();

              foreach (Word word in words)
              {
                if (checkBoxMatchCase.Checked && checkBoxWholeWord.Checked)
                {
                  if (word.Text == textBoxSearchTerm.Text)
                    occurrences++;
                  continue;
                }

                if (checkBoxMatchCase.Checked)
                {
                  if (word.Text.Contains(textBoxSearchTerm.Text))
                    occurrences++;
                  continue;
                }

                if (checkBoxWholeWord.Checked)
                {
                  if (word.Text.ToLower() == textBoxSearchTerm.Text.ToLower())
                    occurrences++;
                  continue;
                }

                if (word.Text.ToLower().Contains(textBoxSearchTerm.Text.ToLower()))
                  occurrences++;
              }
            }
          }
          DataGridViewRow row = (DataGridViewRow)dataGridViewResults.Rows[0].Clone();
          row.Cells[0].Value = Path.GetFileName(pdfFile);
          row.Cells[1].Value = occurrences;
          row.Cells[2].Value = "Open PDF";
          dataGridViewResults.Rows.Add(row);
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Error: {ex}");
        }
      }
    }

    private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        var senderGrid = (DataGridView)sender;

        if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
        {
          string? filename = dataGridViewResults.Rows[e.RowIndex].Cells[0].Value?.ToString();
          if (filename != null)
          {
            var p = new Process();

            p.StartInfo = new ProcessStartInfo(Path.Join(textBoxPath.Text, filename))
            {
              UseShellExecute = true
            };

            p.Start();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error: {ex}");
      }
    }
  }
}