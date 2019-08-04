using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using ObjTransfer;
using Negocios;
using ObjTransfer.Computador;

namespace WinForms
{
    public partial class FormLerText : Form
    {
        string path = @"C:\Txt\DELL 5470.txt";
        public FormLerText()
        {
            InitializeComponent();
        }

        private PC_RamColecao ConsultarMemory()
        {

            List<string[]> listMemory = new List<string[]>();
            string[] memory;
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {

                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("SMBus"))
                    {
                        memory = new string[7];
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("Memory type"))
                                memory[0] = ler;

                            if (ler.Contains("Module format"))
                                memory[1] = ler;

                            if (ler.Contains("Module Manufacturer"))
                                memory[2] = ler;

                            if (ler.Contains("Max bandwidth"))
                                memory[3] = ler;

                            if (ler.Contains("Size"))
                                memory[4] = ler;

                            if (ler.Contains("Serial number"))
                                memory[5] = ler;

                            if (ler.Contains("Nominal Voltage"))
                            {
                                memory[6] = ler;

                                
                                string[] novo = TratarArray(memory);
                                listMemory.Add(novo);
                            }

                            if (ler.Contains("SPD registers"))
                                goto Ram;
                        }
                    }
                }
            Ram:

                PC_RamColecao colecaoRam = new PC_RamColecao();
                foreach (string[] ram in listMemory)
                {
                    PC_Ram RAM = new PC_Ram
                    {
                        Capacidade = ram[4],
                        Fabricante = ram[2],
                        Formato = ram[1],
                        Modelo = ram[3],
                        Serial = ram[5],
                        Tipo = ram[0],
                        Voltagem = ram[6]
                    };

                    colecaoRam.Add(RAM);
                }

                return colecaoRam;
            }
        }
        private string[] FormatTxt(string[] mem)
        {
            List<string> l = new List<string>();
            foreach (string item in mem)
            {
                int i = item.LastIndexOf('!');
                l.Add(item.Substring(i + 1).Trim());
            }

            return l.ToArray();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            PC_MonitorColecao mon;
            PC_Processor_Windows proc;
            PC_RamColecao ram;
            PC_StorageColecao sto;
            PC_Specification spec;
            PC_VideoColecao video;

            if (ValidacaoTxt())
            {
                mon = ConsultarMonitor();
                video = ConsultaVideo();
                spec = ConsultarMainBoard();
                ram = ConsultarMemory();
                sto = ConsultarStorage();
                proc = ConsultaProcessor();

                PreencherForm(mon, proc, ram, sto, spec, video);
            }
            else
                FormMessage.ShowMessegeWarning("Parace que este arquivo Txt não válido, pois não esta no formato padrão!");
        }

        private void PreencherForm(PC_MonitorColecao mon, PC_Processor_Windows proc, PC_RamColecao ram, PC_StorageColecao sto, PC_Specification spec, PC_VideoColecao video)
        {
            textBoxProcModelo.Text = proc.Processor;
            textBoxProcSocket.Text = proc.Socket;

            textBoxPcCategoria.Text = spec.TipoMaquina;
            textBoxPcFab.Text = spec.Fabricante;
            textBoxPcModelo.Text = spec.Produto;
            textBoxPcNome.Text = Path.GetFileNameWithoutExtension(path);
            textBoxPcSerial.Text = spec.SerialMaquina;
            textBoxPcVersao.Text = proc.Windows;

            textBoxPlacaFab.Text = spec.Fornecedor;
            textBoxPlacaModelo.Text = spec.Modelo;
            textBoxPlacaSerial.Text = spec.SerialPlaca;
            textBoxPlacaData.Text = spec.Data;
            textBoxPlacaMax.Text = spec.MemoryMax;
            textBoxPlacaSlot.Text = spec.SlotQuant == "N/D" ? "N/D" : string.Format("{0:00}", Convert.ToInt32(spec.SlotQuant));
            textBoxPlacaFormato.Text = spec.MemoryFormat;
            textBoxPlacaMod.Text = spec.MemoryModulo;

            //for (int i = 0; i < dataGridViewVideo.Columns.Count; i++)
            //    dataGridViewVideo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridViewVideo.AutoGenerateColumns = false;
            dataGridViewVideo.DataSource = video;
            dataGridViewVideo.ClearSelection();

            dataGridViewStorage.AutoGenerateColumns = false;
            dataGridViewStorage.DataSource = sto;
            dataGridViewStorage.ClearSelection();

            dataGridViewMonitor.AutoGenerateColumns = false;
            dataGridViewMonitor.DataSource = mon;
            dataGridViewMonitor.ClearSelection();

            dataGridViewMemory.AutoGenerateColumns = false;
            dataGridViewMemory.DataSource = ram;
            dataGridViewMemory.ClearSelection();

        }

        private PC_StorageColecao ConsultarStorage()
        {
            List<string[]> listStorage = new List<string[]>();
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("Storage"))
                    {
                        string[] storage = new string[5];
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("Name"))
                                storage[0] = ler;

                            if (ler.Contains("Serial"))
                                storage[1] = ler;

                            if (ler.Contains("Capacity"))
                                storage[2] = ler;

                            if (ler.Contains("Type") && !ler.Contains("RAID"))
                                storage[3] = ler.Replace("Fixed", "Interno");

                            if (ler.Contains("Volume"))
                            {
                                storage[4] = ler.Replace(" percent available", "% disponível");

                                string[] novo = TratarArray(storage);
                                listStorage.Add(novo);
                            }

                            if (ler.Contains("USB"))
                                goto Hd;
                        }
                    }
                }
            Hd:
                PC_StorageColecao colecaoStorage = new PC_StorageColecao();
                foreach (string[] storage in listStorage)
                {
                    PC_Storage Storage = new PC_Storage
                    {
                        Capacidade = storage[2],
                        Nome = storage[0],
                        Serial = storage[1],
                        Tipo = storage[3],
                        Volume = storage[4]
                    };

                    colecaoStorage.Add(Storage);
                }

                return colecaoStorage;
            }
        }

        private PC_VideoColecao ConsultaVideo()
        {
            string[] video = new string[4];
            List<string[]> listVideo = new List<string[]>();
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("Display Adapters"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("Name"))
                                video[0] = ler;

                            if (ler.Contains("Board Manufacturer"))
                                video[1] = ler;

                            if (ler.Contains("Memory size"))
                                video[2] = ler;

                            if (ler.Contains("Memory type"))
                                video[3] = ler;

                            if (ler.Contains("Performance Level"))
                            {
                                string[] novo = TratarArray(video);
                                listVideo.Add(novo);
                            }

                            if (ler.Contains("Monitor"))
                                goto Graph;
                        }
                    }
                }
            Graph:

                PC_VideoColecao colecaoVideo = new PC_VideoColecao();
                foreach (string[] item in listVideo)
                {
                    PC_Video Video = new PC_Video
                    {
                        Fabricante = item[1],
                        Memoria = item[2],
                        Nome = item[0],
                        MemoriaTipo = item[3]
                    };

                    colecaoVideo.Add(Video);
                }

                return colecaoVideo;
            }
        }


        private PC_Processor_Windows ConsultaProcessor()
        {
            string[] processor;
            processor = new string[2];
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("Codename"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("Specification"))
                                processor[0] = ler;

                            if (ler.Contains("(Package"))
                            {
                                processor[1] = ler;

                                processor = TratarArray(processor);
                                goto Win;
                            }
                        }
                    }
                }

            Win:
                PC_Processor_Windows ProcessorWin = new PC_Processor_Windows
                {
                    Processor = processor[0],
                    Socket = processor[1],
                    Windows = ConsultarWinVersion()
                };

                return ProcessorWin;
            }
        }

        private string ConsultarData()
        {
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("DMI BIOS"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("date"))
                            {
                                string[] pro = ler.Replace("\t", "!").Split(';');
                                return FormatTxt(pro)[0];
                            }
                        }
                    }
                }

                return "";
            }

        }
        private PC_Specification ConsultarMainBoard()
        {

            string[] mainBoard = new string[12];
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("SMBIOS Version"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("max capacity"))
                                mainBoard[8] = ler;

                            if (ler.Contains("of devices"))
                                mainBoard[7] = ler;

                            if (ler.Contains("DMI Memory Device"))
                            {
                                while ((ler = sr.ReadLine()) != null)
                                {
                                    if (ler.Contains("format"))
                                        mainBoard[10] = ler;

                                    if (ler.Contains("type"))
                                    {
                                        mainBoard[11] = ler;
                                        break;
                                    }
                                }
                            }

                            if (ler.Contains("date"))
                                mainBoard[9] = ler;

                            if (ler.Contains("manufacturer"))
                                mainBoard[0] = ler;

                            if (ler.Contains("product"))
                                mainBoard[1] = ler;

                            if (ler.Contains("serial"))
                            {
                                mainBoard[2] = ler;
                                break;
                            }

                        }

                        if (string.IsNullOrEmpty(mainBoard[9]))
                            mainBoard[9] = ConsultarData();

                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("vendor"))
                                mainBoard[3] = ler;

                            if (ler.Contains("model"))
                                mainBoard[4] = ler;

                            if (ler.Contains("serial"))
                                mainBoard[5] = ler;

                            if (ler.Contains("chassis type"))
                            {
                                mainBoard[6] = ler;

                                mainBoard = TratarArray(mainBoard);

                                string[] data = mainBoard[9].Split('/');
                                mainBoard[9] = data[1] + "/" + data[0] + "/" + data[2];

                                PC_Specification Specification = new PC_Specification
                                {
                                    Fabricante = mainBoard[0],
                                    Fornecedor = mainBoard[3],
                                    Modelo = mainBoard[4],
                                    Produto = mainBoard[1],
                                    SerialMaquina = mainBoard[2],
                                    SerialPlaca = mainBoard[5],
                                    TipoMaquina = mainBoard[6],
                                    MemoryMax = mainBoard[8],
                                    SlotQuant = mainBoard[7],
                                    Data = mainBoard[9],
                                    MemoryFormat = mainBoard[10],
                                    MemoryModulo = mainBoard[11]
                                };

                                return Specification;
                            }
                        }
                    }
                }

                return null;
            }
        }

        private bool ValidacaoTxt()
        {
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                    if (ler.Contains("CPU-Z TXT Report"))
                        while ((ler = sr.ReadLine()) != null)
                            if (ler.Contains("CPU-Z version"))
                                return true;

                return false;
            }
        }

        private PC_MonitorColecao ConsultarMonitor()
        {
            List<string[]> listMonitor = new List<string[]>();
            string[] monitor = new string[5];
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("Monitor "))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {

                            if (ler.Contains("Model"))
                                monitor[0] = ler;

                            if (ler.Contains("ID"))
                                monitor[1] = ler;

                            if (ler.Contains("Manufacturing Date"))
                                monitor[2] = ler.Replace("Week", "Semana").Replace("Year", "Ano");

                            if (ler.Contains("Size"))
                                monitor[3] = ler.Replace("inches", "polegadas");

                            if (ler.Contains("Max Resolution"))
                            {
                                monitor[4] = ler;

                                string[] mon = TratarArray(monitor);
                                listMonitor.Add(mon);
                            }

                            if (ler.Contains("Software"))
                                break;
                        }


                        PC_MonitorColecao colecao = new PC_MonitorColecao();

                        foreach (string[] mon in listMonitor)
                        {
                            PC_Monitor Monitor = new PC_Monitor
                            {
                                Fabricacao = mon[2],
                                ID = mon[1],
                                Modelo = mon[0],
                                Polegada = mon[3],
                                Resolucao = mon[4]
                            };

                            colecao.Add(Monitor);
                        }
                        return colecao;
                    }
                }

                return null;
            }
        }

        private string[] TratarArray(string[] array)
        {
            List<string> l = new List<string>();
            foreach (string item in array)
                if (item != null)
                    l.Add(item.Replace("\t", "!"));
                else
                    l.Add("N/D");

            return FormatTxt(l.ToArray());
        }

        private string ConsultarWinVersion()
        {
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("Windows Version"))
                    {
                        string[] pro = ler.Replace("\t", "!").Split(';');
                        return FormatTxt(pro)[0];
                    }
                }

                return "";
            }
        }
    }
}
