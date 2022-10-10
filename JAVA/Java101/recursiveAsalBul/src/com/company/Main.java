package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Bir sayı giriniz: ");
        int sayi = input.nextInt();

        if (asalMi(sayi, 2))
            System.out.println("Asaldır...");
        else
            System.out.println("Asal değildir...");
    }
    static boolean asalMi(int sayi,int i){
        if (sayi <= 2)
            return (sayi == 2) ? true : false;
        if (sayi % i == 0)
            return false;
        if (i * i > sayi)
            return true;

        // Check for next divisor
        return asalMi(sayi, i + 1);
    }
}
