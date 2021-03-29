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
    public partial class FireWorker : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "pracownicy.txt");
       // private int _workerId;

        public FireWorker(int id = 0)
        {
            InitializeComponent();


            if (id != 0)
            {
                var workers = DeserializeFromFile();
                var worker = workers.FirstOrDefault(x => x.id == id);

                if (worker == null)
                {
                    throw new Exception("Brak pracownika ze wskazanym numerem id");
                }
                
                tbId.Text = worker.id.ToString();
                tbName.Text = worker.Name;
                tbSurname.Text = worker.Surname;
                //dtpToFireData.Text = worker.ToFireData.ToString();
                rtbComments.Text = worker.Comments;
                
            }

            rtbComments.Select();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
           /*var workers = DeserializeFromFile();

            if (_workerId != 0)
            {
                workers.RemoveAll(x => x.id == _workerId);
            }

            var worker = new Worker

            {
                id = _workerId,

                Name = tbName.Text,

                Surname = tbSurname.Text,

                //EmployData = dtpEmployData.ToString("dd/MM/yyyy"),

                //ToFireData = dtpToFireData

                Comments = rtbComments.Text,
            };

            workers.(worker);

            SerializeToFile(workers);

            Close();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
