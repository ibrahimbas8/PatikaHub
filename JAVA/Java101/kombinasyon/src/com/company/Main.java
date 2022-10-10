package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n,r,fakN=1,fakR=1,fakFark=1;

        System.out.print("N değerini giriniz: ");
        n = input.nextInt();

        System.out.print("R değerini giriniz: ");
        r = input.nextInt();


        for (int i=2; i<=n; i++){
            fakN *=i;
            if(i<=r){
                fakR *= i;
            }
            if (i<=(n-r)){
                fakFark *=i;
            }
        }
        int kombinasyon = fakN / (fakR * fakFark);
        System.out.println("Kombinasyon (C(n,r) = n! / (r! * (n-r)!)) : " + kombinasyon);
    }
}
