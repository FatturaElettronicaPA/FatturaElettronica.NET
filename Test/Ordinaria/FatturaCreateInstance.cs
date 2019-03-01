﻿namespace Ordinaria.Tests
{
    using FatturaElettronica.Defaults;
    using FatturaElettronica.Ordinaria;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FatturaCreateInstance
    {
        Fattura challenge;

        [TestMethod]
        public void CreatePubblicaAmministrazioneInstance()
        {
            challenge = Fattura.CreateInstance(Instance.PubblicaAmministrazione);
            Assert.AreEqual(FormatoTrasmissione.PubblicaAmministrazione, challenge.FatturaElettronicaHeader.DatiTrasmissione.FormatoTrasmissione);
        }
        [TestMethod]
        public void CreatePrivatiInstance()
        {
            challenge = Fattura.CreateInstance(Instance.Privati);
            Assert.AreEqual(FormatoTrasmissione.Privati, challenge.FatturaElettronicaHeader.DatiTrasmissione.FormatoTrasmissione);
            Assert.AreEqual("0000000", challenge.FatturaElettronicaHeader.DatiTrasmissione.CodiceDestinatario);
        }
    }
}