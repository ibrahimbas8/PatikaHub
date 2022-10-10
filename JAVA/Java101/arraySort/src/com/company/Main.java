package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Dizi kaç boyutlu olsun : ");
        int boyut = input.nextInt();
        int [] dizi = new int[boyut];

        System.out.println("Dizinin elemanlarını giriniz : ");
        for(int i = 0; i < dizi.length; i++)
        {
            System.out.print((i+1) + ". elemanını giriniz: ");
            dizi[i] = input.nextInt();
        }

        int gecici;
        for(int i = 0; i < dizi.length-1; i++)
        {
            for(int j = i+1; j < dizi.length; j++)
            {
                if(dizi[j] < dizi[i]) {
                    gecici = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = gecici;
                }
            }
        }

        System.out.println("Sıralama : " +  Arrays.toString(dizi));
    }
}
