## lmi-ms-meetup-nsb

### NServiceBus presentation and sample code presented at LogMeIn-Microsoft Enterprise Developers Meetup in Budapest, 2015-03-25. 

Content is in hungarian.

Prezentáció: http://hunpody.github.io/lmi-ms-meetup-20150325-nsb

#### Az előadás után elhangzott kérdések:

(amire emlékszem :))

* Tud SignalR-en kívül más websocketes technológiát használni?

Ez egy nagyon apró kényelmi funkció, ehhez elég megtekinteni, hogy milyen egyszerű volt a ServiceMatrix előtt SignalR-re kötni a különféle üzeneteket: http://benfoster.io/blog/push-notifications-with-nservicebus-and-signalr

	public class MessagePostedEventHandler : IHandleMessages<MessagePostedEvent>
	{
	    public void Handle(MessagePostedEvent message)
	    {
	        var clients = Connection.GetConnection<EventStream>();
	        clients.Broadcast(message.Message);
	    }
	}

* Milyen az áteresztőképessége?

Sajnos hivatalosan csak egy nagyon régi (7 éves) performance-ról szóló cikk érhető el: http://www.udidahan.com/2008/05/21/nservicebus-performance/. Ebben 900 millió üzenet / óra áteresztést értek el.

* Mennyibe kerül pontosan?

Többféle konstrukció van, a kéthetes trial ingyenes. http://particular.net/licensing. Startupoknak (10 fő alatt, 3 évnél fiatalabb és $1 millió éves bevétel alatt) ingyenes. Tévesen 10 milliót mondtam a meetup-on, bocs.

* Hogy nézzük meg a példakódot, ha ez fizetős?

Trial verzióval.

* Min változtatnék, hogy többen is tudják használni a rendszert?

Authorizációs logika felvétele, UserID az üzenetekbe, megfelelő szűrés SignalR. 

* A Saga csak korrelációt képes tárolni?

Bármilyen adatot tárol, alap esetben RavenDB a saga tároló, ahhoz pedig csak Json-ba kell tudni sorosítani az objektumokat.

* Tudsz mondani egy példát, amikor magadnak kell üzenni?

Főleg timeout-oknál hasznos, amikor az üzleti logika olyan, hogy valamilyen feltétel ellenőrzését megadott idővel eltolva kell elvégezni. A bemutatott példához igazodva: beérkezett-e ajánlat, van-e aktivitás, stb. Ilyenkor minden aktivitáskor lehet egy időzített üzenetet küldeni magunknak, ami tudja, hogy mikor volt az utolsó aktivitás, és ha az üzenet visszaérkezésekor nem volt annál újabb, akkor lezárhatjuk a folyamatot például.
