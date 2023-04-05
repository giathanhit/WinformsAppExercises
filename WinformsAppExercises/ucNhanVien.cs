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
	public partial class ucNhanVien : UserControl
	{
		public ucNhanVien()
		{
			InitializeComponent();
		}
		public void Xoa()
		{
			txtMaNV.Text = string.Empty;
			txtTen.Text = string.Empty;
			txtSDT.Text = string.Empty;
			txtDiaChi.Text = string.Empty;
			LayDuLieu();
		}


		public void LayDuLieu()
		{
			nhanVienTableAdapter.Fill(winformsExercisesDataSet.NhanVien);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			Xoa();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				string uuid = Guid.NewGuid().ToString();
				Console.WriteLine(uuid);
				nhanVienTableAdapter.Insert(uuid, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
				LayDuLieu();
			}
			catch (Exception ex) { }
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			nhanVienTableAdapter.UpdateNV(txtTen.Text, txtSDT.Text, txtDiaChi.Text, txtMaNV.Text);
			LayDuLieu();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					nhanVienTableAdapter.Delete(txtMaNV.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
				}
			}
			catch { }
			LayDuLieu();
		}

		private void ucNhanVien_Load(object sender, EventArgs e)
		{
			this.nhanVienTableAdapter.Fill(this.winformsExercisesDataSet.NhanVien);
		}

		private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = new DataGridViewRow();
			row = dgvDanhSach.Rows[e.RowIndex];
			txtMaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
			txtTen.Text = Convert.ToString(row.Cells["TenNV"].Value);
			txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
			txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
		}
	}
}
