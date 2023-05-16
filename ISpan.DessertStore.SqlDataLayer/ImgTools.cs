using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.DessertStore.SqlDataLayer
{
	public class ImageTools
	{
		private static Image _img;
		//public static string fileName;
		public static Image ImportImage()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();//匯入圖片

			openFileDialog.Filter = "All Files|*.*";

			openFileDialog.ShowDialog();

			if(openFileDialog.FileName!=string.Empty) _img = new Bitmap(openFileDialog.FileName);
			return _img;
			//this.pictureBox1.Image = img;
		}

		//private void button2_Click(object sender, EventArgs e)
		//{
		//	if (textBox1.Text == string.Empty)
		//	{
		//		var teat = from c in HW.Teat2
		//				   select c;
		//		dataGridView1.DataSource = teat.ToList();
		//	}
		//	else
		//	{
		//		var teat = from c in HW.Teat2
		//				   where c.Account.Contains(textBox1.Text)
		//				   select c;
		//		dataGridView1.DataSource = teat.ToList();
		//	}
		//}


	}
}
