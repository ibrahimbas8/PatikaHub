package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Sayi giriniz : ");
        int sayi = input.nextInt();

        System.out.println(palindromMu(sayi));
    }
    static boolean palindromMu(int sayi){
        int gecici = sayi, tersSayi = 0, sonSayi;

        while (gecici != 0){
            sonSayi =gecici%10;
            tersSayi = (tersSayi*10) + sonSayi;
            gecici /=10;
        }

        if (sayi == tersSayi)
            return true;
        else
            return false;
    }
}
