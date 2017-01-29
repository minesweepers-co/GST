using System;
using System.Collections;

namespace GST.DataObjects
{
    class Purchase
    {
        public string date, party, vchType, vchNo, vchRef,
                         stno, serviceTaxNo, panNo, cstNo, narr,
                         grossAmount;
        public ArrayList ledAmount;

        public Purchase(string lineData)
        {
            String[] data = lineData.Split(',');
            date = data[0];
            party = data[1];
            vchType = data[2];
            vchNo = data[3];
            vchRef = data[4];
            stno = data[5];
            serviceTaxNo = data[6];
            panNo = data[7];
            cstNo = data[8];
            narr = data[9];
            grossAmount = data[10];
            ledAmount = new ArrayList();
            for (int i = 11; i < data.Length; i++)
            {
                ledAmount.Add(data[i]);
            }
        }
    }
}
