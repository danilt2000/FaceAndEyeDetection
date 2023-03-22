<h1>Detekce obličeje a očí</h1>
<p style="white-space: pre-line">
Požadavky na absolvování


V tomto úkolu si vyzkoušíte práci s knihovnou (nejen) pro zpracování obrazu - OpenCV.

Velmi jednoduchým příkladem je např. detekce konkrétních objektů. Využijeme toho, že mnohé věci jsou už v OpenCV předpřipraveny a zkusíte si jednoduchou detekci obličeje a očí z obrázku/videa.

Konkrétní body zadání:

Korektně (pozor na barevné kanály) načtěte libovolný obrázek obsahující alespoň jeden obličej. (2b)

Pomocí dostupných Haar kaskád openCV detekujte obličej a ten vykreslete. (3b)

Využijte jinou Haar kaskádu pro detekci očí. (3b)

Přidejte nějakou vlastní invenci (barva očí, zpracování videa na vstupu, detekce úsměvu, jiné objekty, dokreslete si brýle apod.). (2b)

</p>
Příklad:

<img width="700" height="700" src="https://user-images.githubusercontent.com/75219332/227021838-b7f079b5-7b1d-49f9-a3f8-e0080c08748c.png"></img>
<h2>The task was completed and here are examples of the processed images</h2>
<table>
  <tr>
    <td><img width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227024745-d57ac175-cc5c-46b8-b64d-aa2fe1a3ffb9.jpg"></td>
    <td><img width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227024915-ec4944b9-73dd-4068-8ef6-5c5b917e6da4.jpg"></td>
    <td><img width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227025062-753fa509-6378-48c7-a8c1-5181ad02b0c4.jpg"></td>
  </tr>
  <tr>
    <td><img width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227025140-8e75406b-4aef-494e-9d3f-75e26c448a0a.jpg"></td>
    <td><img width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227025460-0e923ceb-5638-4b24-bb97-7fd2cd814135.jpg"></td>
    <td><img  width="300" height="300" src="https://user-images.githubusercontent.com/75219332/227025505-47deedd6-fdc9-4d43-affb-ae5904acc8fe.jpg"></td>
  </tr>
</table>
<h2>I used haarcascades from here</h2>
<a href="https://github.com/opencv/opencv/tree/master/data/haarcascades">Haarcascades</a>
<h3>The work was done by Danil Tkachenko </h3>

