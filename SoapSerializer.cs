using System;

namespace WindowsFormsApp1
{
    internal class SoapSerializer
    {
        private Type type;

        public SoapSerializer(Type type)
        {
            this.type = type;
        }
    }
}