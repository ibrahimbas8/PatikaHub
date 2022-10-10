package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int startPrice=10,min= 20, km;
	    double perKm= 2.20,total;

        Scanner input = new Scanner(System.in);
        System.out.print("Kaç km gideceksiniz :");
        km= input.nextInt();

        total=(perKm*km) + startPrice;

        boolean buyukMu = total >= 20;
        System.out.println("Taksi Ücreti = " + (buyukMu==true ? total : min));
    }
}
