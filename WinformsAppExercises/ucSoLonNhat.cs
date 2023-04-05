using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAppExercises
{
	public partial class ucSoLonNhat : UserControl
	{
		public ucSoLonNhat()
		{
			InitializeComponent();
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			int a = int.Parse(txtA.Text);
			int b = int.Parse(txtB.Text);
			int c = int.Parse(txtC.Text);
			if (rdoSoLonNhat.Checked == true)
			{
				int max;
				max = a;

				if (max < b || max == b)
				{
					max = b;
					txtKetQua.Text = "Số lớn nhất:" + max;
					if (max < c || max == c)
					{

						max = c;
						txtKetQua.Text = "Số lớn nhất:" + max;
					}
				}
				else
					txtKetQua.Text = "Số lớn nhất:" + max;
			}
			else if (rdoSoNhoNhat.Checked == true)
			{
				int min;
				min = a;
				if (min > b || min == b)
				{
					min = b;
					txtKetQua.Text = "Số nhỏ nhất:" + min;
					if (min > c || min == c)
						min = c;
					txtKetQua.Text = "Số nhỏ nhất:" + min;
				}
				else
					txtKetQua.Text = "Số nhỏ nhất:" + min;
			}
		}

		private void rdoSoLonNhat_CheckedChanged(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
		}

		private void rdoSoNhoNhat_CheckedChanged(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			txtA.Text = string.Empty;
			txtB.Text = string.Empty;
			txtC.Text = string.Empty;
			txtKetQua.Text = string.Empty;
		}
	}
}
