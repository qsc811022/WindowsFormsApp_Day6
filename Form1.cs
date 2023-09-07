using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Day6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int sum=Convert.ToInt32(textBox1.Text)+Convert.ToInt32(textBox2.Text);

			label1.Text=Convert.ToString(sum);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			int sum = Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox4.Text);
			label2.Text = Convert.ToString(sum);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int sum = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text);
			label3.Text = Convert.ToString(sum);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int sum = Convert.ToInt32(textBox7.Text) / Convert.ToInt32(textBox8.Text);
			label4.Text = Convert.ToString(sum);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			int sum = Convert.ToInt32(textBox7.Text) % Convert.ToInt32(textBox8.Text);
			label5.Text = Convert.ToString(sum);
		}
	}
	
}
