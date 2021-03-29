using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Workers_List
{
    public partial class Main : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "pracownicy.txt");

        public Main()
        {

            /* var _path = $@"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\ListaPracowników.txt";

            if (!File.Exists(_path))

                System.IO.File.Create(_path);*/

            InitializeComponent();

            var workers = DeserializeFromFile();

            dgvWorkersList.DataSource = workers;
           
        }


        public void SerializeToFile(List<Worker> workers)
        {
            var serializer = new XmlSerializer(typeof(List<Worker>));
           
            using (var streamWriter = new StreamWriter(_filePath))
            { 
                serializer.Serialize(streamWriter, workers);
                streamWriter.Close();
            }
           
        }

        public List<Worker> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Worker>();
            }

            var serializer = new XmlSerializer(typeof(List<Worker>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var workers = (List<Worker>)serializer.Deserialize(streamReader);

                streamReader.Close();

                return workers;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditWorker = new AddEditWorker();

            addEditWorker.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var workers = DeserializeFromFile();

            dgvWorkersList.DataSource = workers;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            if (dgvWorkersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika, którego dane chcesz zedytować");
                return;
            }
               var addEditWorker = new AddEditWorker(Convert.ToInt32(dgvWorkersList.SelectedRows[0].Cells[0].Value));

                addEditWorker.ShowDialog();
            
        }

        private void btnToFire_Click(object sender, EventArgs e)
        {
            if (dgvWorkersList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika, którego chcesz zwolnić");
                return;
            }
            var fireworker = new FireWorker(Convert.ToInt32(dgvWorkersList.SelectedRows[0].Cells[0].Value));

            fireworker.ShowDialog();

        }
    }
}
