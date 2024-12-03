# Notes

* ⚠️ **WIP**
* ✅ **GREEN**
* 🧠 **In Discovery**
* ❌ **RED**
* 📝 **TBD**

### Goal:
### Time 🍅
### Notes:

Karta ->
Läser av position av skeppen -> skapa sjöflottor och piratskeppet
loopa tills piratskeppet kommit till kanten eller piratskeppet blir fångat
loop:
flytta alla skepp
kolla om fångad

Sjöflottan
1. ~~har en kolumn~~
2. ~~har en start riktning~~
3. ~~den ska röra sig varje runda (upp eller ner)~~
4. den ska vända vid kanten

Piratskeppet
1. ~~har en rad~~
2. ~~har position~~
3. ~~ska röra sig varje runda~~
4. när den kommit till högra kanten är den säker

Kurs
1. ~~X000 -> true -> kan returnera true~~ 
   * (hade kunnat skapa skeppsobjekten redan här)
   * instans metod för checkcourse, property för skeppen, asserta på propertyn?
2. ~~X0N0 -> false -> sjöflotta i vägen~~ 
   * (hade kunnat komma efter räckhålls-checken, och implementerat move loop)
3. X000 -> false -> sjöflotta är inom räckhåll
   0N00
   * (skapa skepp objekt och check för räckhåll, men inte loopen ännu)
4. X00N -> true -> sjöflotta finns men är inte i vägen
   0000
   0000
   0000
5. X000 -> dem kommer att krocka
   0000
   0000
   000N
6. x börjar på annat än topprad

Karta ->
Läser av position av skeppen -> skapa sjöflottor och piratskeppet
loopa tills piratskeppet kommit till kanten eller piratskeppet blir fångat