package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int sayi1, sayi2, sayi3, orta, buyuk, kucuk;

        Scanner input = new Scanner(System.in);

        System.out.println("1. Sayıyı giriniz : ");
        sayi1 = input.nextInt();

        System.out.println("2. Sayıyı giriniz : ");
        sayi2 = input.nextInt();

        System.out.println("3. Sayıyı giriniz : ");
        sayi3 = input.nextInt();

        if ( (sayi1>sayi2) && (sayi1>sayi3)){
            if (sayi2>sayi3){
                buyuk = sayi1;
                orta = sayi2;
                kucuk = sayi3;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
            else{
                buyuk = sayi1;
                orta = sayi3;
                kucuk = sayi2;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
        }
        else if (sayi2>sayi1 && sayi2>sayi3){
            if (sayi1>sayi3){
                buyuk = sayi2;
                orta = sayi1;
                kucuk = sayi3;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
            else{
                buyuk = sayi2;
                orta = sayi3;
                kucuk = sayi1;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
        }
        else{
            if (sayi1>sayi2){
                buyuk = sayi3;
                orta = sayi1;
                kucuk = sayi2;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
            else{
                buyuk = sayi3;
                orta = sayi2;
                kucuk = sayi1;
                System.out.println(kucuk + " < " + orta + " < " + buyuk);
            }
        }

    }
}
