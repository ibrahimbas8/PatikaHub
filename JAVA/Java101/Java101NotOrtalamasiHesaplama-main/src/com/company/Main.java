package com.company;


import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int mat,fizik,kimya,turkce,tarih,muzik;
        Scanner input = new Scanner(System.in);

        System.out.print("Matematik Dersi notu:");
        mat = input.nextInt();

        System.out.print("Fizik Dersi notu:");
        fizik = input.nextInt();

        System.out.print("Kimya Dersi notu:");
        kimya = input.nextInt();

        System.out.print("Türkçe Dersi notu:");
        turkce = input.nextInt();

        System.out.print("Tarih Dersi notu:");
        tarih = input.nextInt();

        System.out.print("Müzik Dersi notu:");
        muzik = input.nextInt();

        int toplam = (mat+ fizik+ kimya + turkce+ tarih+ muzik);
        int ortalama = toplam/6;

        System.out.println("Not ortalamanız: " + ortalama);

        boolean gectiMi = ortalama >= 50;
        System.out.println("Durum = " + (gectiMi==true ? "Geçti" : "Kaldı"));
    }
}
