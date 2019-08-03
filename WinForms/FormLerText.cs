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
        PC_Specification Specification;
        PC_Processor_Windows ProcessorWin;
        PC_StorageColecao colecaoStorage;
        PC_RamColecao colecaoRam;


        string path = @"C:\Txt\DESKTOP-4NKQ48S.txt";
        List<string[]> listMemory = new List<string[]>();
        string winSystem;
        public FormLerText()
        {
            InitializeComponent();
        }

        private void ConsultarMemory()
        {
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
                colecaoRam = new PC_RamColecao();
                foreach (string[] ram in listMemory)
                {
                    PC_Ram RAM = new PC_Ram
                    {
                        Capacidade  = ram[4],
                        Fabricante = ram[2],
                        Formato = ram[1],
                        Modelo = ram[3],
                        Serial = ram[5],
                        Tipo = ram[0],
                        Voltagem = ram[6]
                    };

                    colecaoRam.Add(RAM);
                }
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
            if (ValidacaoTxt())
            {
                ConsultarMainBoard();
                ConsultarMemory();
                ConsultarStorage();
                ConsultaProcessor();
            }
            else
                FormMessage.ShowMessegeWarning("Parace que este arquivo Txt não válido, pois não esta no formato padrão!");
        }

        private void ConsultarStorage()
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
                colecaoStorage = new PC_StorageColecao();
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
            }
        }

        private void ConsultaProcessor()
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

                            if (ler.Contains("(platform"))
                            {
                                processor[1] = ler;

                                List<string> l = new List<string>();
                                foreach (string item in processor)
                                    if (item != null)
                                        l.Add(item.Replace("\t", "!"));

                                processor = new string[2];
                                processor = FormatTxt(l.ToArray());

                                ProcessorWin = new PC_Processor_Windows
                                {
                                    Processor = processor[0],
                                    Socket = processor[1],
                                    Windows = ConsultarWinVersion()
                                };

                                return;
                            }
                        }


                    }
                }
            }
        }

        private void ConsultarMainBoard()
        {

            string[] mainBoard;
            mainBoard = new string[7];
            string ler = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((ler = sr.ReadLine()) != null)
                {
                    if (ler.Contains("DMI System Information"))
                    {
                        while ((ler = sr.ReadLine()) != null)
                        {
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

                                mainBoard = new string[7];
                                mainBoard = FormatTxt(l.ToArray());

                                Specification = new PC_Specification
                                {
                                    Fabricante = mainBoard[0],
                                    Fornecedor = mainBoard[3],
                                    Modelo = mainBoard[4],
                                    Produto = mainBoard[1],
                                    SerialMaquina = mainBoard[2],
                                    SerialPlaca = mainBoard[5],
                                    TipoMaquina = mainBoard[6],
                                };
                                
                                return;
                            }
                        }
                    }
                }
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
    }
}
