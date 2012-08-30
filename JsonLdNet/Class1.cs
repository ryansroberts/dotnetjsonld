using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JsonLdNet
{
    public class Quad
    {
        
    }

    public class JsonJdOptions
    {
        public JsonJdOptions(Uri iri = null)
        {
            IRI = iri ?? new Uri("");
            CompactArrays = true;
        }

        public Uri IRI { get; private set; }
        public bool CompactArrays { get; set; }
        public bool Optimize { get; set; }
        public bool UseRdfType { get; set; }
        public bool UseNativeTypes { get; set; }
    }


    public class JSonLdProcessor
    {
        public void ToRDF(JObject jsonld,Func<Quad> quadCallback,JsonJdOptions options )
        {
            
        }
    }
}
