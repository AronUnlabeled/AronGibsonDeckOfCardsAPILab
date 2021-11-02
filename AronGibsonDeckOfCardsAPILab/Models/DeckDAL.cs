using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AronGibsonDeckOfCardsAPILab.Models
{
    public class DeckDAL
    {
        public DeckModel GetData() {

            string url = "https://deckofcardsapi.com/api/deck/0tur1m4uetwf/draw/?count=5";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();
            DeckModel deck = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return deck;
        }

        public DeckModel ShuffleCards()
        {

            string url = "https://deckofcardsapi.com/api/deck/0tur1m4uetwf/shuffle/";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();
            DeckModel deck = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return deck;
        }


    }
}
