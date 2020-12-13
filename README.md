# IRF_Project
Juhász Viktor IRF Beadandó projektje

Rövid bemutatás:
  A projektem egy elektronikai termékek eládásval foglalkozó üzletnek alkotja a lekérdező rendszerét.
Egy terméknek 4 tulajdonsága van, a nevén kívül (a név egyedi mindegyiknél) 1. a gyártási ideje,2. a gyártója,3. a színe, illetve 4. az ára.

Program működése:
  A termékek szűréséhez, először érdemes megnéznünk milyen termékekre tudunk rákeresni, ebben a termékpaletta nevezetű gomb segít, amellyel letudjuk kérdezni az aktuálisan forgalmazott termékeket.
Majd a form1-en a keresés gombtól balra lévő textboxba rátudunk keresni az általunk kiválaszott termékekre név alapján és erről a termékről megtudhatjuk minden tulajdonságát.
Ezt követően kilistázzuk az összes termékünket a tulajdonságokkal együtt egy listboxba.
A listboxból tudjuk törölni az általunk kiválasztott elemet, a törlés gombbal, illetve törölhetünk megadott feltétel alapján is, amely esetünkben az ár lesz.
Megadhatunk külön-külön minimum és maximum értéket is, illetve kombinálhatjuk a két tulajdonságot is, ilyenkor a két ár közötti termékek maradnak csak bent a listába, a többi elem törlésre kerül. Ha újabb listára szeretnénk szűrni, akkor a listáz gomb ismételt megnyomásával betölti az összes termékünket a program.
A mentés gomb segítségével a szűrt listánkat elmenthetjük egy csv file-ba, ahol a fejléc segít egyértelműsíteni a tulajdonságokat.
Az elégedettség értékelése gomb egy új form-ra vezet át minket, ahol egy trackbaron tudjuk jelezni, hogy mennyire voltunk elégedettek a programmal.

Felhasznált elemek és azok Name és Text tulajdonsága:
  Buttonok 8 db:
    Kereses       - Keresés
    termekpaletta - Termékpaletta
    ListaGomb     - Listáz
    TorlesGomb    - Törlés
    TorlesArSzerintGomb - Ár szerinti törlés
    Mentes        - Mentés
    ElegedettsegErt - Elégedettség Értékelése
    Jovahagyas    - Értékelés jóváhagyása
   Listák 3db:
    keresesieredmeny
    termeklista
    listView1
   Textboxok 3db:
    keresesinput
    MinimumAr
    MaximumAr
   Labelek 3db:
    label1       - Minimum
    label2       - Maximum
    label2       - Form2 Felirata
Egyéb elemek:
Form1, Form2, Termekek XML, Termek osztály, Trackbarosztaly, labelosztaly
Commitok száma: 10db
