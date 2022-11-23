<h1 align="center"> MyCalories </h1>

<center> Sebuah aplikasi untuk menjaga kalori yang dikonsumsi tetap terjaga dan rekomendasi kegiatan untuk membakarnya. Aplikasi ini bisa menghitung kalori, BMI (Body Mass Index), dan BRI (Body Roundness Index) </center>

## KELOMPOK 7

Ketua Kelompok: Muhamad Thoriq Ahnaf (20/460553/TK/51142) <br>
Anggota 1: Danurrizad Ryan Darmoko (20/463597/TK/51589)<br>
Anggota 2: Saddan Syah Akbar (20/460566/TK/51155)<br>


## Usecase Diagram
![MicrosoftTeams-image](https://user-images.githubusercontent.com/73093118/190052070-0ba4b6a2-7ad7-41e5-8670-24264cb07e76.png)
## Activity Diagram
![Diagram drawio](https://user-images.githubusercontent.com/73093118/190052100-a0177409-16d8-4e71-8d98-d8a65c48de0c.png)
## Class Diagram
![MyCalories drawio (2)](https://user-images.githubusercontent.com/73093118/191302156-85171720-9f42-4be2-85fe-63312716ea15.png)

## ERD 
![ERD_MyCalories](https://user-images.githubusercontent.com/79238162/192665838-d67b1c0d-c65f-4c26-89c2-a09e78301cf8.jpeg)

## Cara setup MyCalories
### Build Solution
- Pilih configuration manager menjadi release
- Build -> Build Solution
- Folder hasil build ada pada direktori bin/Release
### Config Database
- Buka PgAdmin4
- Buat roles baru dengan username: kaloriku dan password: kaloriku12345
- Pastikan role kaloriku memiliki properties Privileges dengan ketentuan :
	- Can login? (Centang)
	- Superuser? (Centang)
- Buat database dengan nama : dbmycalories
- Buka PSQL Tool pada database dbmycalories, lalu tulis command \i <path sqlnya>
- Contoh : \i C:/Users/legion/Desktop/Junior Project/Release/backup.sql
- Jalankan program!
