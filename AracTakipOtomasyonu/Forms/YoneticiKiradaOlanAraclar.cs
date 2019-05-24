﻿using BusinessLayer.Repositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakipOtomasyonu.Forms
{
    public partial class YoneticiKiradaOlanAraclar : Form
    {
        public YoneticiKiradaOlanAraclar()
        {
            InitializeComponent();
        }
        List<Araclar> araclar = null;
        private void btn_KiradaOlanAraclar_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            List<Araclar> araclar = arac.KiralandiMiyeGoreGetir();
            for (int i = 0; i < araclar.Count; i++)
            {
                dt_KiradaOlanAraclar.DataSource = araclar;
            }
        }

        private void YoneticiKiradaOlanAraclar_Load(object sender, EventArgs e)
        {

        }
    }
}
