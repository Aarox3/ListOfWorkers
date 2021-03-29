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
    public partial class AddEditWorker : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "pracownicy.txt");
        private int _workerId;
        public AddEditWorker(int id = 0)
        {
            InitializeComponent();

            _workerId = id;

            if (id != 0)
            {
                var workers = DeserializeFromFile();
                var worker = workers.FirstOrDefault(x => x.id == id);
                worker.EmployData = DateTime.MaxValue;

                if (worker == null)
                {
                    throw new Exception("Brak pracownika ze wskazanym numerem id");
                }

                tbId.Text = worker.id.ToString();
                tbName.Text = worker.Name;
                tbSurname.Text = worker.Surname;
                dtpEmployData.Text = worker.EmployData.ToString();
                tbSalary.Text = worker.Salary;
                rtbComments.Text = worker.Comments;
            }

            tbName.Select();
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
            var workers = DeserializeFromFile();

            if (_workerId != 0)
            {
                workers.RemoveAll(x => x.id == _workerId);
            }

            else
            { 
                var workerWithHighestId = workers.OrderByDescending(x => x.id).FirstOrDefault();

           
            /*var workerId = 0;

            if (workerWithHighestId == null)
            {
                workerId = 1;
            }

            else
            {
                workerId = workerWithHighestId.id + 1;
            }  TO NIŻEJ TO TA SAMA LOGIKA, ALE ŁATWIEJ ZAPISANA */

            _workerId = workerWithHighestId == null ? 1 : workerWithHighestId.id + 1;
            }

            var worker = new Worker

            {
                id = _workerId,

                Name = tbName.Text,

                Surname = tbSurname.Text,

                //EmployData = dtpEmployData.ToString("dd/MM/yyyy"),

                //ToFireData = dtpToFireData

                Salary = tbSalary.Text,

                Comments = rtbComments.Text,
            };

            workers.Add(worker);

            SerializeToFile(workers);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
