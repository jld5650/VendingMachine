using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


namespace VendingMachine
{
    
    public partial class Form1 : Form
    {
        private Machine vm;
        public decimal amountDeposited = 0m;
        Button btnQuarter = new Button();
        Button btnDime = new Button();
        Button btnNickel = new Button();
        public TextBox txtAmount= new TextBox();
        
        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }
        public static Form1 _Form1;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
       {
           Snack[] obj = new Snack[10];
           obj[0] = new Snack();
           obj[1] = new Snack();
           obj[2] = new Snack();
           obj[3] = new Snack();
           obj[4] = new Snack();
           obj[5] = new Snack();
           obj[6] = new Snack();
           obj[7] = new Snack();
           obj[8] = new Snack();
           obj[9] = new Snack();
         
           Drinks[] obej = new Drinks[10];
           obej[0] = new Drinks();
           obej[1] = new Drinks();
           obej[2] = new Drinks();
           obej[3] = new Drinks();
           obej[4] = new Drinks();
           obej[5] = new Drinks();
           obej[6] = new Drinks();
           obej[7] = new Drinks();
           obej[8] = new Drinks();
           obej[9] = new Drinks();

           Candy[] obbj = new Candy[10];
           obbj[0] = new Candy();
           obbj[1] = new Candy();
           obbj[2] = new Candy();
           obbj[3] = new Candy();
           obbj[4] = new Candy();
           obbj[5] = new Candy();
           obbj[6] = new Candy();
           obbj[7] = new Candy();
           obbj[8] = new Candy();
           obbj[9] = new Candy();
          
            obj[0].name = "Lays";
            obj[0].price = Convert.ToDecimal(.45);
            obj[0].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\lays-potato-chips-regular.jpg";
            obj[0].id = "A1";
            obj[0].type = "Chips";
            obj[0].inventory = 1;
            obj[1].name = "Doritos";
            obj[1].price = Convert.ToDecimal(.45);
            obj[1].id = "A2";
            obj[1].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\doritos.jpg";
            obj[1].inventory = 16;
            obj[2].name = "Snyders";
            obj[2].price = Convert.ToDecimal(.45);
            obj[2].id = "A3";
            obj[2].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\snyders.jpg";
            obj[2].inventory = 16;
            obj[3].name = "Combos";
            obj[3].price = Convert.ToDecimal(.45);
            obj[3].id = "B4";
            obj[3].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\combos.jpg";
            obj[3].inventory = 16;
     
            obej[0].name = "Pepsi";
            obej[0].price = Convert.ToDecimal(.85);
            obej[0].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\pepsi.jpg";
            obej[0].id = "B5";
            obej[0].type = "Soda";
            obej[0].inventory = 16;
            obej[1].name = "Coca Cola";
            obej[1].price = Convert.ToDecimal(.85);
            obej[1].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\coke.jpg";
            obej[1].id = "B6";
            obej[1].type = "Soda";
            obej[1].inventory = 16;
            obej[2].name = "Pepsi";
            obej[2].price = Convert.ToDecimal(.85);
            obej[2].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\gatorade.jpg";
            obej[2].id = "B7";
            obej[2].type = "Juice";
            obej[2].inventory = 16;
            obej[3].name = "Aquafina";
            obej[3].price = Convert.ToDecimal(.85);
            obej[3].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\water.jpg";
            obej[3].id = "C8";
            obej[3].type = "Water";
            obej[3].inventory = 16;
      
            obbj[0].name = "Swedish Fish";
            obbj[0].price = Convert.ToDecimal(.95);
            obbj[0].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\fish.jpg";
            obbj[0].id = "C9";
            obbj[0].type = "Gummy";
            obbj[0].inventory = 16;
            obbj[1].name = "Hershey";
            obbj[1].price = Convert.ToDecimal(.95);
            obbj[1].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\hershey.png";
            obbj[1].id = "C0";
            obbj[1].type = "Chocoloate";
            obbj[1].inventory = 16;
            obbj[2].name = "Skittles";
            obbj[2].price = Convert.ToDecimal(.95);
            obbj[2].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\skittles.jpg";
            obbj[2].id = "D1";
            obbj[2].type = "Bite-Size";
            obbj[2].inventory = 16;
            obbj[3].name = "Reese's";
            obbj[3].price = Convert.ToDecimal(.85);
            obbj[3].img = "C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\reeses.jpg";
            obbj[3].id = "D2";
            obbj[3].type = "Chocolate";
            obbj[3].inventory = 16;

            XmlSerializer serializer = new XmlSerializer(typeof(Snack[]));
            Stream stream = new FileStream
                  ("Snacks.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(stream, obj);
            stream.Close();
            XmlSerializer serializer1 = new XmlSerializer(typeof(Drinks[]));
            Stream stream1 = new FileStream
                  ("Drinks.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializer1.Serialize(stream1, obej);
            stream1.Close();
            XmlSerializer serializer2 = new XmlSerializer(typeof(Candy[]));
            Stream stream2 = new FileStream
                  ("Candy.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            serializer2.Serialize(stream2, obbj);
            stream2.Close();
            
          
                vm = new Machine();

                for (int x = 0; x < vm.picArray.Length; x++)
                {
                    this.Controls.Add(vm.picArray[x]);
                    this.Controls.Add(vm.lblArray[x]);
                    this.Controls.Add(vm.lblArray[x]);
                    this.Controls.Add(vm.lblArray1[x]);
                    this.Controls.Add(vm.picArray1[x]);
                    this.Controls.Add(vm.lblArray2[x]);
                    this.Controls.Add(vm.picArray2[x]);

                }

                for (int x = 0; x < vm.btnArray.Length; x++)
                {
                    this.Controls.Add(vm.btnArray[x]);
                    this.Controls.Add(vm.btnArray1[x]);
                    this.Controls.Add(vm.btnArray2[x]);
                }
                Size FormSize = new Size(800, 600);
                this.Size = (FormSize);
                this.BackColor = Color.FromArgb(26, 67, 207);
                Point pntQuarter = new Point(5,350);
                Point pntDime = new Point(70, 465);
                Point pntNickel = new Point(110,350);
                btnQuarter.BackgroundImage =Image.FromFile("C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\quarter.png");
                btnQuarter.Size = new Size(100,100);
                btnQuarter.Location = pntQuarter;
                btnDime.Size = new Size(70, 90);
                btnDime.BackgroundImage = Image.FromFile("C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\dime.jpg");
                btnDime.Location = pntDime;
                //Nickel Button
                btnNickel.Location = pntNickel;
                btnNickel.BackgroundImage = Image.FromFile("C:\\Users\\owner\\Documents\\School\\IST 240\\VendingMachine\\VendingMachine\\Pictures\\nickel.jpg");
                btnNickel.Size = new Size(90, 100);
                btnNickel.Click += coinClick;
                btnQuarter.Click += coinClick;
                btnDime.Click += coinClick;
                //Amount Deposited
                txtAmount.Location = new Point(350, 450);
                txtAmount.ReadOnly = true;
                txtAmount.ForeColor = Color.GreenYellow;
                txtAmount.BackColor = Color.Black;
                this.Controls.Add(btnQuarter);
                this.Controls.Add(btnDime);
                this.Controls.Add(btnNickel);
                this.Controls.Add(txtAmount);
            }
                

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void coinClick(object sender, EventArgs e)
        {
            if (sender == btnQuarter && amountDeposited < .76m)
            {
                amountDeposited += .25m;
            }
            else if (sender == btnDime & amountDeposited < .91m)
            {
                amountDeposited += .10m;
            }
         
            else if (sender == btnNickel && amountDeposited < .96m)
            {
                amountDeposited += .05m;
            }
            txtAmount.Text = Convert.ToString(amountDeposited);
             
        }

    }
}
