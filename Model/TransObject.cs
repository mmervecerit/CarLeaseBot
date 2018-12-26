using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracKiralama.Model
{

    public class TransObject
    {
        [JsonProperty(PropertyName = "detectedLanguage")]
        public DetectedLanguage DetectedLanguage { get; set; }

        [JsonProperty(PropertyName = "translations")]
        public Translation[] Translations { get; set; }

    }

    public class DetectedLanguage
    {
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "score")]
        public float Score { get; set; }
    }

    public class Translation
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

       
        /*
        [JsonProperty(PropertyName = "transliteration")]
        public Transliteration Transliteration { get; set; }

        [JsonProperty(PropertyName = "alignment")]
        public Alignment Alignment { get; set; }

        [JsonProperty(PropertyName = "sentLen")]
        public SentLen SentLen { get; set; }

        [JsonProperty(PropertyName = "sourceText")]
        public SourceText SourceText { get; set; }
        */
    }
    /*
    public class SourceText
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }

    public class SentLen
    {
        [JsonProperty(PropertyName = "srcSentLen")]
        public int[] SrcSentLen { get; set; }

        [JsonProperty(PropertyName = "transSentLen")]
        public int[] TransSentLen { get; set; }
    }

    public class Alignment

    {
        [JsonProperty(PropertyName = "proj")]
        public string Proj { get; set; }
    }

    public class Transliteration
    {
        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }*/
}