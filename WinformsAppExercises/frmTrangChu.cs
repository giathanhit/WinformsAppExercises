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
	public partial class frmTrangChu : Form
	{
		public frmTrangChu()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox10_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lbSoLonNho_Click(object sender, EventArgs e)
		{
			ucSoLonNhat ucSoLon = new ucSoLonNhat();
			panelChinh.Controls.Clear();
			panelChinh.Controls.Add(ucSoLon);
		}

		private void lbNhanVien_Click(object sender, EventArgs e)
		{
			ucNhanVien ucNhanVien = new ucNhanVien();
			panelChinh.Controls.Clear();
			panelChinh.Controls.Add(ucNhanVien);
		}

		private void lbGiaiPT_Click(object sender, EventArgs e)
		{ 
			ucGiaiPT ucGiaiPT = new ucGiaiPT();
			panelChinh.Controls.Clear();
			panelChinh.Controls.Add(ucGiaiPT);
		}
	}
}
