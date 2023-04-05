using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsAppExercises.WinformsExercisesDataSetTableAdapters;

namespace WinformsAppExercises
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();

		}

		QueriesTableAdapter q = new QueriesTableAdapter();
		public static string taikhoan = "";
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			try
			{
				string tenDN = txtTenDN.Text;
				string matKhau = txtMatKhau.Text;
				if (tenDN != "" && matKhau != "")
				{
					if ((int)q.dangnhap(tenDN, matKhau) == 1)
					{
						taikhoan = tenDN;
						MessageBox.Show("Đăng nhập thành công!!");
						frmTrangChu frmTrangChu = new frmTrangChu();
						this.Hide();
						frmTrangChu.ShowDialog();
					}
					else
					{
						MessageBox.Show("Mật khâu hoặc tên đăng nhập không đúng!!");
					}
				}
				else if (txtTenDN.Text == "")
				{
					errorProvider1.SetError(txtTenDN, "Vui lòng nhập tên đăng nhập");
				}
				else if (txtMatKhau.Text == "")
				{
					errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
			this.taiKhoanTableAdapter.Fill(this.winformsExercisesDataSet.TaiKhoan);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
