using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Bank;

namespace VendingMachine
{
    internal class Machine
    {
        public Machine()
        {
            XmlSerializer serializer = new XmlSerializer(typeof (Snack[]));
            Stream stream = new FileStream
                ("Snacks.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Snack[] obj = (Snack[]) serializer.Deserialize(stream);
            stream.Close();

            XmlSerializer serializer1 = new XmlSerializer(typeof (Drinks[]));
            Stream stream1 = new FileStream
                ("Drinks.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Drinks[] obej = (Drinks[]) serializer1.Deserialize(stream1);
            stream1.Close();

            XmlSerializer serializer2 = new XmlSerializer(typeof (Candy[]));
            Stream stream2 = new FileStream
                ("Candy.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Candy[] obbj = (Candy[]) serializer2.Deserialize(stream2);
            stream2.Close();

            btnArray = new Button[10];
            btnArray1 = new Button[10];
            btnArray2 = new Button[10];
            picArray = new PictureBox[10];
            lblArray = new Label[10];
            picArray1 = new PictureBox[10];
            lblArray1 = new Label[10];
            picArray2 = new PictureBox[10];
            lblArray2 = new Label[10];
            int z = 0;
            int t = 0;
            int a = 0;

            for (int x = 0; x < 2; x++)
            {
                int j = 1;

                for (int y = 0; y < 2; y++)
                {
                    btnArray[t] = new Button();
                    btnArray[t].Size = new Size(32, 30);
                    btnArray[t].Text = obj[t].id;
                    btnArray[t].Location = new Point(250 + a, 350 + j);
                    btnArray[t].BackColor = Color.Black;
                    btnArray[t].ForeColor = Color.White;
                    btnArray[t].Font = new Font(btnArray[z].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    btnArray[t].Click += coinClickId;

                    t++;
                    j += 45;
                }
                a += 35;
            }
            t = 0;
            for (int x = 2; x < 4; x++)
            {
                int j = 1;

                for (int y = 0; y < 2; y++)
                {
                    btnArray1[t] = new Button();
                    btnArray1[t].Size = new Size(32, 30);
                    btnArray1[t].Text = obej[t].id;
                    btnArray1[t].Location = new Point(250 + a, 350 + j);
                    btnArray1[t].BackColor = Color.Black;
                    btnArray1[t].ForeColor = Color.White;
                    btnArray1[t].Font = new Font(btnArray[t].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    btnArray1[t].Click += coinClickId2;

                    t++;
                    j += 45;
                }
                a += 35;
            }

            t = 0;
            for (int x = 2; x < 4; x++)
            {
                int j = 1;

                for (int y = 0; y < 2; y++)
                {
                    btnArray2[t] = new Button();
                    btnArray2[t].Size = new Size(32, 30);
                    btnArray2[t].Text = obbj[t].id;
                    btnArray2[t].Location = new Point(250 + a, 350 + j);
                    btnArray2[t].BackColor = Color.Black;
                    btnArray2[t].ForeColor = Color.White;
                    btnArray2[t].Font = new Font(btnArray2[t].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    btnArray2[t].Click += coinClickId3;

                    t++;
                    j += 45;
                }
                a += 35;
            }
            for (int x = 0; x < 2; x++)
            {
                double f = 1;
                for (int y = 0; y < 2; y++)
                {
                    picArray[z] = new PictureBox();
                    picArray[z].ImageLocation = @obj[z].img; //Image.FromFile(location);
                    picArray[z].Location = new Point(125*x, 150*y);
                    picArray[z].Size = new Size(100, 100);
                    lblArray[z] = new Label();
                    lblArray[z].Location = new Point(127*x, Convert.ToInt16(100*f));
                    lblArray[z].Text = obj[z].id + "           $" + obj[z].price;
                    lblArray[z].BackColor = Color.Black;
                    lblArray[z].ForeColor = Color.White;
                    lblArray[z].Font = new Font(lblArray[z].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    z++;
                    f = 2.5;
                }
            }
            int e = 0;

            for (int x = 2; x < 4; x++)
            {
                double f = 1;
                for (int y = 0; y < 2; y++)
                {
                    picArray1[e] = new PictureBox();
                    picArray1[e].ImageLocation = @obej[e].img; //Image.FromFile(location);
                    picArray1[e].Location = new Point(125*x, 150*y);
                    picArray1[e].Size = new Size(100, 100);
                    lblArray1[e] = new Label();
                    lblArray1[e].Location = new Point(127*x, Convert.ToInt16(100*f));
                    lblArray1[e].Text = obej[e].id + "          $" + obej[e].price;
                    lblArray1[e].BackColor = Color.Black;
                    lblArray1[e].ForeColor = Color.White;
                    lblArray1[e].Font = new Font(lblArray[e].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    e++;
                    f = 2.5;
                }
            }
            int g = 0;
            for (int x = 4; x < 6; x++)
            {
                double f = 1;
                for (int y = 0; y < 2; y++)
                {
                    picArray2[g] = new PictureBox();
                    picArray2[g].ImageLocation = @obbj[g].img; //Image.FromFile(location);
                    picArray2[g].Location = new Point(132*x, 150*y);
                    picArray2[g].Size = new Size(100, 100);
                    lblArray2[g] = new Label();
                    lblArray2[g].Location = new Point(127*x, Convert.ToInt16(100*f));
                    lblArray2[g].Text = obbj[g].id + "          $" + obbj[g].price;
                    lblArray2[g].BackColor = Color.Black;
                    lblArray2[g].ForeColor = Color.White;
                    lblArray2[g].Font = new Font(lblArray[g].Font.Name, 8, FontStyle.Bold | FontStyle.Underline);
                    g++;
                    f = 2.5;
                }
            }
        }

        public void coinClickId(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof (Snack[]));
            Stream stream = new FileStream
                ("Snacks.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Snack[] obj = (Snack[]) serializer.Deserialize(stream);
            stream.Close();

            string b = ((Button) sender).Text;
            for (int x = 0; x < 10; x++)
            {
                if (b == obj[x].id)
                {
                    if (Form1._Form1.amountDeposited >= obj[x].price)
                    {
                        if (obj[x].inventory == 0)
                        {
                            MessageBox.Show("This item is out of stock!", "Vending Machine");
                        }
                        if (obj[x].inventory > 0)
                        {
                            CoinChange CC = Service.TotalChange(obj[x].price, Form1._Form1.amountDeposited);
                            decimal totalChange = (CC.Quarter*.25m) + (CC.Dime*.10m) + (CC.Nickel*.05m);
                            if (MessageBox.Show("Your Purchased " + obj[x].name +
                                                "\nQuarters: " + CC.Quarter.ToString() +
                                                "\nDimes: " + CC.Dime.ToString() +
                                                "\nNickels: " + CC.Nickel.ToString() + "\nTotal Change: $" + totalChange,
                                "Vending Machine", MessageBoxButtons.OK) == DialogResult.OK)
                                obj[x].inventory -= 1;
                            Form1._Form1.amountDeposited = 0;
                            Form1._Form1.txtAmount.Text = Convert.ToString(Form1._Form1.amountDeposited);

                            XmlSerializer serializerA = new XmlSerializer(typeof (Snack[]));
                            Stream streamA = new FileStream
                                ("Snacks.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                            serializerA.Serialize(streamA, obj);
                            streamA.Close();
                        }
                    }
                    else if (Form1._Form1.amountDeposited < obj[x].price)
                    {
                        MessageBox.Show("Please insert the correct amount");
                    }
                }
            }
        }

        public void coinClickId2(object sender, EventArgs e)
        {
            XmlSerializer serializer1 = new XmlSerializer(typeof (Drinks[]));
            Stream stream1 = new FileStream
                ("Drinks.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Drinks[] obej = (Drinks[]) serializer1.Deserialize(stream1);
            stream1.Close();
            string b = ((Button) sender).Text;
            for (int x = 0; x < 10; x++)
            {
                if (b == obej[x].id)
                {
                    if (Form1._Form1.amountDeposited >= obej[x].price)
                    {
                        if (obej[x].inventory == 0)
                        {
                            MessageBox.Show("This item is out of stock!", "Vending Machine");
                        }
                        if (obej[x].inventory > 0)
                        {
                            CoinChange CC = Service.TotalChange(obej[x].price, Form1._Form1.amountDeposited);
                            decimal totalChange = (CC.Quarter*.25m) + (CC.Dime*.10m) + (CC.Nickel*.05m);
                            if (MessageBox.Show("Your Purchased " + obej[x].name +
                                                "\nQuarters: " + CC.Quarter.ToString() +
                                                "\nDimes: " + CC.Dime.ToString() +
                                                "\nNickels: " + CC.Nickel.ToString() + "\nTotal Change: $" + totalChange,
                                "Vending Machine", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                Form1._Form1.amountDeposited = 0;
                                Form1._Form1.txtAmount.Text = Convert.ToString(Form1._Form1.amountDeposited);
                            }
                            obej[x].inventory -= 1;
                            XmlSerializer serializerB = new XmlSerializer(typeof (Drinks[]));
                            Stream streamB = new FileStream
                                ("Drinks.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                            serializerB.Serialize(streamB, obej);
                            streamB.Close();
                        }

                        else if (Form1._Form1.amountDeposited < obej[x].price)
                        {
                            MessageBox.Show("Please insert the correct amount");
                        }
                    }
                }
            }
        }

        public void coinClickId3(object sender, EventArgs e)
        {
            XmlSerializer serializer2 = new XmlSerializer(typeof (Candy[]));
            Stream stream2 = new FileStream
                ("Candy.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            Candy[] obbj = (Candy[]) serializer2.Deserialize(stream2);
            stream2.Close();
            string b = ((Button) sender).Text;
            for (int x = 0; x < 10; x++)
            {
                if (b == obbj[x].id)
                {
                    if (obbj[x].inventory == 0)
                    {
                        MessageBox.Show("This item is out of stock!", "Vending Machine");
                    }

                    else if (obbj[x].inventory > 0)
                    {
                        if (Form1._Form1.amountDeposited >= obbj[x].price)
                        {
                            CoinChange CC = Service.TotalChange(obbj[x].price, Form1._Form1.amountDeposited);
                            decimal totalChange = (CC.Quarter*.25m) + (CC.Dime*.10m) + (CC.Nickel*.05m);
                            if (MessageBox.Show("Your Purchased " + obbj[x].name +
                                                "\nQuarters: " + CC.Quarter.ToString() +
                                                "\nDimes: " + CC.Dime.ToString() +
                                                "\nNickels: " + CC.Nickel.ToString() + "\nTotal Change: $" + totalChange,
                                "Vending Machine", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                Form1._Form1.amountDeposited = 0;
                                Form1._Form1.txtAmount.Text = Convert.ToString(Form1._Form1.amountDeposited);
                            }
                            
                            obbj[x].inventory -= 1;
                            XmlSerializer serializerC = new XmlSerializer(typeof (Candy[]));
                            Stream streamC = new FileStream
                                ("Candy.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                            serializerC.Serialize(streamC, obbj);
                            streamC.Close();
                        }

                        else if (Form1._Form1.amountDeposited < obbj[x].price)
                        {
                            MessageBox.Show("Please insert the correct amount");
                        }
                    }
                }
            }
        }


        public PictureBox[] picArray { get; set; }
        public Label[] lblArray { get; set; }
        public Button[] btnArray { get; set; }
        public PictureBox[] picArray1 { get; set; }
        public Label[] lblArray1 { get; set; }
        public Button[] btnArray1 { get; set; }
        public PictureBox[] picArray2 { get; set; }
        public Button[] btnArray2 { get; set; }
        public Label[] lblArray2 { get; set; }
    }
}