using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace JSONOperations
{
    public partial class Form1 : Form
    {

        string _JSONDataasString;
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFilePathforJSON = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Json Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "txt files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFilePathforJSON.ShowDialog() == DialogResult.OK)
            {
                txtJSONFilePath.Text = openFilePathforJSON.FileName;
                var filePath = (txtJSONFilePath.Text);
                _JSONDataasString = File.ReadAllText(filePath);
                //var data123 = File.ReadAllBytes(filePath);
                _JSONDataasString = JsonConvert.SerializeObject(_JSONDataasString);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (_JSONDataasString != null)
            {
                var data = JsonConvert.DeserializeObject(_JSONDataasString.ToString());
                var listNames = JArray.Parse(data.ToString()).Select(x => x.SelectToken("Name")).ToList().Distinct();
                var commaSeperatedList = String.Join(", ", listNames);
                var lastComma = commaSeperatedList.LastIndexOf(',');
                if (lastComma != -1)
                    commaSeperatedList = commaSeperatedList.Remove(lastComma, 1).Insert(lastComma, " and ");

                rtxtData.Text = commaSeperatedList.ToString();
            }
            else
            {
                rtxtData.Text = string.Empty;
            }

        }
    }
}
