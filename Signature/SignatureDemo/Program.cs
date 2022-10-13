using System;
using System.Security.Cryptography;
using System.Text;

namespace SignatureDemo
{
    internal class Program
    {
        internal static CngKey aliceKeySignature;
        internal static byte[] alicePubKeyBlob;

        static void CreateKeys()
        {
            aliceKeySignature = CngKey.Create(CngAlgorithm.ECDsaP256);
            alicePubKeyBlob = aliceKeySignature.Export(CngKeyBlobFormat.GenericPublicBlob);
        }

        static byte[] CreateSignature(byte[] data, CngKey key)
        {
            byte[] signature;
            var signingAlg = new ECDsaCng(key);
            signature = signingAlg.SignData(data);
            signingAlg.Clear();
            return signature;
        }

        static bool VerifySignature(byte[] data, byte[] signature, byte[] pubKey)
        {
            bool retValue = false;
            using (CngKey key = CngKey.Import(pubKey, CngKeyBlobFormat.GenericPublicBlob))
            {
                var signingAlg = new ECDsaCng(key);
                retValue = signingAlg.VerifyData(data, signature);
                signingAlg.Clear();
            }

            return retValue;
        }

        static void Main()
        {
            CreateKeys();

            byte[] aliceData = Encoding.UTF8.GetBytes("Alice");
            byte[] aliceSignature = CreateSignature(aliceData, aliceKeySignature);
            Console.WriteLine("Alice created signature: {0}", Convert.ToBase64String(aliceSignature));

            if (VerifySignature(aliceData, aliceSignature, alicePubKeyBlob))
            {
                Console.WriteLine("Alice signature verified successfully");
            }
            else
            {
                Console.WriteLine("Alice signature verified error");
            }
            
            byte[] boobData = Encoding.UTF8.GetBytes("Boob");
            if (VerifySignature(boobData, aliceSignature, alicePubKeyBlob))
            {
                Console.WriteLine("Boob signature verified successfully");
            }
            else
            {
                Console.WriteLine("Boob signature verified error");
            }
        }
    }
}