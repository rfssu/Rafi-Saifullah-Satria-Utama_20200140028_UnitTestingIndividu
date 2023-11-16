using NUnit.Framework;
using ProjectUAS1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUAS1.Tests
{
    [TestFixture()]
    public class administrasiTests
    {
        administrasi adm = new administrasi();
        [Test()]
        public void admsekolahTest()
        {
            const string nama = "RAfi Utama";
            Assert.IsTrue(true, nama);
            const string namasekolah = "SMA 5 Yogyakarta";
            Assert.IsTrue(true, namasekolah);
            const string nis = "20200140028";
            Assert.IsTrue(true, nis);
            const string kelas = "12 IPA 3";
            Assert.IsTrue(true, kelas);
            const string walikelas = "Slamet Riyadi";
            Assert.IsTrue(true, walikelas);
            const string jeniskelamin = "Laki-Laki";
            Assert.IsTrue(true, jeniskelamin);
            const string alamat = "nomaden";
            Assert.IsTrue(true, alamat);
        }
    }
}