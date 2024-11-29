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
1. har en kolumn
   1. 
2. har en start riktning
2. den ska röra sig varje runda (upp eller ner)
3. den ska vända vid kanten

Piratskeppet
1. har en rad
2. ska röra sig varje runda
3. när den kommit till högra kanten är den säker

Kurs
1. ~~X000 -> true -> kan returnera true~~
2. ~~X0N0 -> false -> sjöflotta i vägen~~
3. X00N -> true -> sjöflotta finns men är inte i vägen
   0000
   0000
   0000
4. X000 -> dem kommer att krocka
   0000
   0000
   000N
5. x börjar på annat än topprad

Karta ->
Läser av position av skeppen -> skapa sjöflottor och piratskeppet
loopa tills piratskeppet kommit till kanten eller piratskeppet blir fångat