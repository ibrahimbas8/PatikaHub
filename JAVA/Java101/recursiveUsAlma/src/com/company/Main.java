package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int sayi, us, result ;
        System.out.print("Sayıyı giriniz: ");
        sayi=input.nextInt();

        System.out.print("Üs değerini giriniz : ");
        us = input.nextInt();

        result = usAlma(sayi,us);
        System.out.println("Sonuç : " + result);
    }
    static int usAlma(int sayi, int us){
       if (us == 0) return 1;
       //else if(sayi==1) return 1;
       else return sayi * usAlma(sayi,us-1);
    }
}
