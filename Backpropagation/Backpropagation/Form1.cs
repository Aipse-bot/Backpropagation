using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backpropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        private int clickCount = 0;
        private int hiddenNeurons = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string textFromTextBox8 = textBox8.Text;
            int INTvalue;
            if(int.TryParse(textFromTextBox8, out INTvalue))
            {
                hiddenNeurons = INTvalue;
            }
            else
            {
                hiddenNeurons = 100;
            }

            string textFromTextBox3 = textBox3.Text;
            float FLOATvalue;

            if (float.TryParse(textBox3.Text, out FLOATvalue))
            {
                textBox7.Text = textFromTextBox3;

                if (FLOATvalue <= 0.90)
                {
                    clickCount++;
                }
            }
            else
            {
                textBox7.Text = textFromTextBox3;
                clickCount++;
            }

            textBox6.Text = hiddenNeurons  + " * " + clickCount;

            double[,] inputs = {
                { 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, 0.0, 1.0 },
                { 0.0, 0.0, 1.0, 0.0 },
                { 0.0, 0.0, 1.0, 1.0 },
                { 0.0, 1.0, 0.0, 0.0 },
                { 0.0, 1.0, 0.0, 1.0 },
                { 0.0, 1.0, 1.0, 0.0 },
                { 0.0, 1.0, 1.0, 1.0 },
                { 1.0, 0.0, 0.0, 0.0 },
                { 1.0, 0.0, 0.0, 1.0 },
                { 1.0, 0.0, 1.0, 0.0 },
                { 1.0, 0.0, 1.0, 1.0 },
                { 1.0, 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 0.0, 1.0 },
                { 1.0, 1.0, 1.0, 0.0 },
                { 1.0, 1.0, 1.0, 1.0 }
            };

            double[] outputs = {
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            };

            for (int i = 0; i < hiddenNeurons; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    nn.setInputs(0, inputs[j, 0]);
                    nn.setInputs(1, inputs[j, 1]);
                    nn.setInputs(2, inputs[j, 2]);
                    nn.setInputs(3, inputs[j, 3]);
                    nn.setDesiredOutput(0, outputs[j]);
                    nn.learn();
                }
            }

    }

    private void button3_Click(object sender, EventArgs e)
        {
            
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox4.Text));
            nn.setInputs(2, Convert.ToDouble(textBox2.Text));
            nn.setInputs(3, Convert.ToDouble(textBox5.Text));

            nn.run();

            textBox3.Text = "" + nn.getOuputData(0);

            string textFromTextBox3 = textBox3.Text;
            float value;

            if (float.TryParse(textBox3.Text, out value))
            {
                textBox7.Text = textFromTextBox3;
            }
            else
            {
                textBox7.Text = "Not Float";      
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, hiddenNeurons, 1);
            clickCount = 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max= 0;
                int t;
            int.TryParse(textBox12.Text, out max);
            string textFromTextBox8 = textBox8.Text;
            int INTvalue;
            if (int.TryParse(textFromTextBox8, out INTvalue))
            {
                hiddenNeurons = INTvalue;
            }
            else
            {
                hiddenNeurons = 100;
            }

            //1st step
            nn = new NeuralNet(4, hiddenNeurons, 1);
                clickCount = 0;

                //2nd step

                for(t = 0; t < max; t++)
                {



                double[,] inputs = {
                        { 0.0, 0.0, 0.0, 0.0 },
                        { 0.0, 0.0, 0.0, 1.0 },
                        { 0.0, 0.0, 1.0, 0.0 },
                        { 0.0, 0.0, 1.0, 1.0 },
                        { 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 1.0, 0.0, 1.0 },
                        { 0.0, 1.0, 1.0, 0.0 },
                        { 0.0, 1.0, 1.0, 1.0 },
                        { 1.0, 0.0, 0.0, 0.0 },
                        { 1.0, 0.0, 0.0, 1.0 },
                        { 1.0, 0.0, 1.0, 0.0 },
                        { 1.0, 0.0, 1.0, 1.0 },
                        { 1.0, 1.0, 0.0, 0.0 },
                        { 1.0, 1.0, 0.0, 1.0 },
                        { 1.0, 1.0, 1.0, 0.0 },
                        { 1.0, 1.0, 1.0, 1.0 }
                    };

                        double[] outputs = {
                        0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                        0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                    };

                        for (int i = 0; i < hiddenNeurons; i++)
                        {
                            for (int j = 0; j < 16; j++)
                            {
                                nn.setInputs(0, inputs[j, 0]);
                                nn.setInputs(1, inputs[j, 1]);
                                nn.setInputs(2, inputs[j, 2]);
                                nn.setInputs(3, inputs[j, 3]);
                                nn.setDesiredOutput(0, outputs[j]);
                                nn.learn();
                            }
                        }
                    nn.setInputs(0, Convert.ToDouble(textBox1.Text));
                    nn.setInputs(1, Convert.ToDouble(textBox4.Text));
                    nn.setInputs(2, Convert.ToDouble(textBox2.Text));
                    nn.setInputs(3, Convert.ToDouble(textBox5.Text));

                    nn.run();

                    textBox3.Text = "" + nn.getOuputData(0);

                    string textFromTextBox3 = textBox3.Text;
                    float FLOATvalue;

                    if (float.TryParse(textBox3.Text, out FLOATvalue))
                    {
                        textBox7.Text = textFromTextBox3;

                        if (FLOATvalue <= 0.90)
                        {
                            clickCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        textBox7.Text = textFromTextBox3;
                        clickCount++;
                    }

                    textBox6.Text = hiddenNeurons + " * " + clickCount;
                    textBox9.Text = hiddenNeurons + " * " + clickCount;

                    textFromTextBox3 = textBox3.Text;
                    float value;

                    if (float.TryParse(textBox3.Text, out value))
                    {
                        textBox7.Text = textFromTextBox3;
                    }
                    else
                    {
                        textBox7.Text = "Not Float";
                    }
            }
                if(t == max)
            {
                textBox9.Text = "did not reach efficiency of  > 90%";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int max = 0;
            float prev = 0;
            int min = 0;
            float FLOATvalue = 0.0f;

            int.TryParse(textBox11.Text, out max);
            int f;
            for (f = 0; f < max; f++)
            {
                //1st step
                nn = new NeuralNet(4, f, 1);
                clickCount = 0;

                //2nd step


                    hiddenNeurons = f;


                    

                    double[,] inputs = {
                        { 0.0, 0.0, 0.0, 0.0 },
                        { 0.0, 0.0, 0.0, 1.0 },
                        { 0.0, 0.0, 1.0, 0.0 },
                        { 0.0, 0.0, 1.0, 1.0 },
                        { 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 1.0, 0.0, 1.0 },
                        { 0.0, 1.0, 1.0, 0.0 },
                        { 0.0, 1.0, 1.0, 1.0 },
                        { 1.0, 0.0, 0.0, 0.0 },
                        { 1.0, 0.0, 0.0, 1.0 },
                        { 1.0, 0.0, 1.0, 0.0 },
                        { 1.0, 0.0, 1.0, 1.0 },
                        { 1.0, 1.0, 0.0, 0.0 },
                        { 1.0, 1.0, 0.0, 1.0 },
                        { 1.0, 1.0, 1.0, 0.0 },
                        { 1.0, 1.0, 1.0, 1.0 }
                    };

                    double[] outputs = {
                        0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                        0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                    };

                    for (int i = 0; i < hiddenNeurons; i++)
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            nn.setInputs(0, inputs[j, 0]);
                            nn.setInputs(1, inputs[j, 1]);
                            nn.setInputs(2, inputs[j, 2]);
                            nn.setInputs(3, inputs[j, 3]);
                            nn.setDesiredOutput(0, outputs[j]);
                            nn.learn();
                        }
                    }
                    nn.setInputs(0, Convert.ToDouble(textBox1.Text));
                    nn.setInputs(1, Convert.ToDouble(textBox4.Text));
                    nn.setInputs(2, Convert.ToDouble(textBox2.Text));
                    nn.setInputs(3, Convert.ToDouble(textBox5.Text));

                    nn.run();
                    textBox3.Text = "" + nn.getOuputData(0);

                    string textFromTextBox3 = textBox3.Text;
                    float.TryParse(textBox3.Text, out FLOATvalue);

                    prev = FLOATvalue;




                    for (int i = 0; i < hiddenNeurons; i++)
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            nn.setInputs(0, inputs[j, 0]);
                            nn.setInputs(1, inputs[j, 1]);
                            nn.setInputs(2, inputs[j, 2]);
                            nn.setInputs(3, inputs[j, 3]);
                            nn.setDesiredOutput(0, outputs[j]);
                            nn.learn();
                        }
                    }
                    nn.setInputs(0, Convert.ToDouble(textBox1.Text));
                    nn.setInputs(1, Convert.ToDouble(textBox4.Text));
                    nn.setInputs(2, Convert.ToDouble(textBox2.Text));
                    nn.setInputs(3, Convert.ToDouble(textBox5.Text));

                    nn.run();

                textBox3.Text = "" + nn.getOuputData(0);

                textFromTextBox3 = textBox3.Text;
                float.TryParse(textBox3.Text, out FLOATvalue);

                

                textFromTextBox3 = textBox3.Text;

                if (prev < FLOATvalue)
                {
                    textBox10.Text = "Learn at " + f;
                    break;
                }
                else
                {
                    textBox10.Text = "dumb";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
