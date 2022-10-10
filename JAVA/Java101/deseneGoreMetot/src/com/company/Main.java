package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Sayı giriniz:");
        int sayi= input.nextInt();

        deseneGore(sayi,sayi);
    }
    static boolean altSinir = false;
    static int deseneGore(int sayi,int temp){

        if (sayi<=0) altSinir=true;
        if (sayi>-5 && altSinir==false){
            System.out.println(sayi);
            return deseneGore(sayi-5,temp);
        }
        else if (temp == sayi){
            System.out.println(sayi);
            return temp;
        }
        else {
            System.out.println(sayi);
            return deseneGore(sayi+5,temp);
        }
    }
}
