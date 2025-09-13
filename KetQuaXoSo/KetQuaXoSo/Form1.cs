using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace KetQuaXoSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void rbMIenNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMIenNam.Checked) HienThiKetQua();
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            HienThiKetQua();
        }

        private void rbMIenBac_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMIenBac.Checked) HienThiKetQua();
        }

        private void rbMIenTrung_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMIenTrung.Checked) HienThiKetQua();
        }
        private void HienThiKetQua()
        {
            
            try
            {
                string mien = rbMIenBac.Checked ? "bac" : rbMIenNam.Checked ? "nam" : "trung";
                var ketQua = LayKetQua(mien, dtpNgay.Value);

                tabKetQua.TabPages.Clear();
                foreach (var dai in ketQua.Keys)
                {
                    var tab = new TabPage(dai);

                    var grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = ketQua[dai],
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };
                   
                    tab.Controls.Add(grid);
                    tabKetQua.TabPages.Add(tab);
                }
                if (ketQua.Count == 0)
                {
                    tabKetQua.TabPages.Add(new TabPage("Khong co du lieu"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<KetQua> LayKetQuaTuRSS(string rssUrl)
        {
            var ketQua = new List<KetQua>();
            
            XmlDocument doc = new XmlDocument();
            doc.Load(rssUrl);
            XmlNodeList items = doc.SelectNodes("//item");
            foreach(XmlNode item in items)
            {
                string description = item.SelectSingleNode("description").InnerText;
                string[] lines = description.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                DateTime ngay = LayNgay(item);
                string daiHienTai = "Không có";
                if (rssUrl.Contains("mien-bac"))
                {
                    daiHienTai = "Hà Nội";
                }
                
                foreach (var line in lines)
                {

                    string trimmedLine = line.Trim();
                    if (trimmedLine.StartsWith("[") && trimmedLine.Contains("]"))
                    {
                        int start = trimmedLine.IndexOf("[") + 1;
                        int end = trimmedLine.IndexOf("]");
                        if (start < end)
                        {
                            daiHienTai = trimmedLine.Substring(start, end - start).Trim();
                        }
                    }
                    else if (trimmedLine.Contains(":"))
                    {
                        string[] parts = trimmedLine.Split(':');
                        KetQua kq = new KetQua();
                        if (parts.Length == 2)
                        {
                            string giai = parts[0].Trim();
                            string soTrung = parts[1].Trim();
                            kq.Dai = daiHienTai;
                            kq.Ngay = ngay;
                            kq.Giai = giai;
                            kq.soTrungThuong = soTrung;
                            ketQua.Add(kq);

                        }
                    }



                }
            }

            return ketQua;
        }
        public DateTime LayNgay(XmlNode item)
        {
            DateTime ngay;
            XmlNode pubDateNode = item.SelectSingleNode("pubDate");
            if (pubDateNode != null)
            {
                string dateText = pubDateNode.InnerText;
                if (dateText.Contains("/")) 
                { 
                    string[] dateParts = dateText.Split('/');
                    int ngayPart = int.Parse(dateParts[0]);
                    int thangPart = int.Parse(dateParts[1]);
                    int namPart = int.Parse(dateParts[2]);
                    ngay = new DateTime(namPart, thangPart, ngayPart);
                    return ngay.Date;
                
                }
            }
            return DateTime.Now.Date;
        }
        public Dictionary<string, List<KetQua>> LayKetQua(string mien, DateTime ngay)
        {
            string rssUrl;
            if (mien == "bac")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-bac-xsmb.rss";
            }
            else if (mien == "trung")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-trung-xsmt.rss";
            }
            else if (mien == "nam")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-nam-xsmn.rss";
            }
            else
            {
                throw new ArgumentException("Mien khong hop le");
            }
            var ketQua = LayKetQuaTuRSS(rssUrl);

            ketQua = ketQua.Where(kq => kq.Ngay.Date == ngay.Date).ToList();

            var ketQuaTheoDai = new Dictionary<string, List<KetQua>>();
            foreach (KetQua kq in ketQua)
            {
                string dai = kq.Dai;
                if (!ketQuaTheoDai.ContainsKey(dai))
                {
                    ketQuaTheoDai[dai] = new List<KetQua>();
                }
                ketQuaTheoDai[dai].Add(kq);
            }
            return ketQuaTheoDai;

           
        }
    }
}
