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
        string winSystem;
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

                                List<string> l = new List<string>();

                                foreach (string item in memory)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!"));

                                memory = new string[7];
                                string[] novo = FormatTxt(l.ToArray());
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
                if (!string.IsNullOrEmpty(item))
                {
                    int i = item.LastIndexOf('!');
                    l.Add(item.Substring(i + 1).Trim());
                }
                else
                    l.Add(item);
            }

            return l.ToArray();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            PC_Monitor mon;
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

        private void PreencherForm(PC_Monitor mon, PC_Processor_Windows proc, PC_RamColecao ram, PC_StorageColecao sto, PC_Specification spec, PC_VideoColecao video)
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
            textBoxPlacaSlot.Text = spec.SlotQuant;
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
                                storage[3] = ler;

                            if (ler.Contains("Volume"))
                            {
                                storage[4] = ler;

                                List<string> l = new List<string>();

                                foreach (string item in storage)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!").Replace(" percent available", "% disponível").Replace("Fixed", "Interno"));

                                storage = new string[5];
                                string[] novo = FormatTxt(l.ToArray());
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
            string[] video = new string[3];
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
                            {
                                video[2] = ler;

                                List<string> l = new List<string>();
                                foreach (string item in video)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!"));

                                video = new string[3];
                                string[] novo = FormatTxt(l.ToArray());
                                listVideo.Add(novo);

                                if (ler.Contains("Monitor"))
                                    goto Graph;
                            }
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

                                List<string> l = new List<string>();
                                foreach (string item in processor)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!"));

                                processor = new string[2];
                                processor = FormatTxt(l.ToArray());
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

        private PC_Specification ConsultarMainBoard()
        {

            string[] mainBoard = new string[10];
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("DMI Physical Memory Array"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
                            if (ler.Contains("max capacity"))
                                mainBoard[8] = ler;

                            if (ler.Contains("of devices"))
                                mainBoard[7] = ler;

                            if (ler.Contains("date"))
                                mainBoard[9] = ler;
                            else
                                mainBoard[9] = "";

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

                                List<string> l = new List<string>();

                                foreach (string item in mainBoard)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!"));

                                mainBoard = new string[10];
                                mainBoard = FormatTxt(l.ToArray());


                                PC_Specification Specification = new PC_Specification
                                {
                                    Fabricante = mainBoard[0],
                                    Fornecedor = mainBoard[3],
                                    Modelo = mainBoard[4],
                                    Produto = mainBoard[1],
                                    SerialMaquina = mainBoard[2],
                                    SerialPlaca = mainBoard[5],
                                    TipoMaquina = mainBoard[6],
                                    MemoryMax = mainBoard[7],
                                    SlotQuant = mainBoard[8],
                                    Data = mainBoard[9]
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

        private PC_Monitor ConsultarMonitor()
        {
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
                                monitor[4] = ler;

                            if (ler.Contains("Software"))
                                break;
                        }

                        List<string> l = new List<string>();
                        foreach (string item in monitor)
                            if (item != null)
                                l.Add(item.Replace("\t", "!"));

                        string[] mon = FormatTxt(l.ToArray());


                        PC_Monitor Monitor = new PC_Monitor
                        {
                            Fabricacao = mon[2],
                            ID = mon[1],
                            Modelo = mon[0],
                            Polegada = mon[3],
                            Resolucao = mon[4]
                        };
                        return Monitor;
                    }
                }

                return null;
            }
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
                        return winSystem = FormatTxt(pro)[0];
                    }
                }

                return "";
            }
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxPlacaSerial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
