using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{
    internal class MyMethods
    {

        //appeler avec les params "nom" et "prenom"
        public string bonjour(NameValueCollection paramsCollection)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<HTML><BODY> Bonjour ");
            sb.Append(paramsCollection.Get("prenom")+" ");
            sb.Append(paramsCollection.Get("nom"));
            sb.Append(" </BODY></HTML>");
            return sb.ToString();
        }

        public string ping(NameValueCollection paramsCollection)
        {
            return "<HTML><BODY>pong</BODY></HTML>";
        }
    }
}
