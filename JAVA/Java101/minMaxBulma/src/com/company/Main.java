package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int min,max,sayi,adet;
        Scanner input = new Scanner(System.in);

        System.out.print("Kaç sayı gireceksiniz: ");
        adet = input.nextInt();

        System.out.print(1+ " . sayıyı giriniz: ");
        sayi = input.nextInt();
        max = sayi;
        min = sayi;

        for (int i=2; i<=adet; i++){
            System.out.print(i+ " . sayıyı giriniz: ");
            sayi = input.nextInt();

            if (sayi>max){
                max= sayi;
            }
            else if(sayi< min){
                min = sayi;
            }
        }
        System.out.println("En büyük sayı: " + max);
        System.out.println("En küçük sayı: " + min);
    }
}
