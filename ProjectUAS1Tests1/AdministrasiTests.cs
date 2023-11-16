using NUnit.Framework;
using ProjectUAS1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUAS1.Tests
{
    [TestFixture()]
    public class AdministrasiTests
    {
        Administrasi adm = new Administrasi();
        [Test()]
        public void MainTest()
        {
            const string nama = "Muhammad Irsyad Rizky Ananda";
            Assert.IsTrue(true, nama);
            const string namasekolah = "SMA 2 Payakumbuh";
            Assert.IsTrue(true, namasekolah);
            const string nis = "20200140070";
            Assert.IsTrue(true, nis);
            const string kelas = "12 IPA 2";
            Assert.IsTrue(true, kelas);
            const string walikelas = "Harris Setyawan";
            Assert.IsTrue(true, walikelas);
            const string jeniskelamin = "Laki-Laki";
            Assert.IsTrue(true, jeniskelamin);
            const string alamat = "Padang";
            Assert.IsTrue(true, alamat);
        }
    }
}