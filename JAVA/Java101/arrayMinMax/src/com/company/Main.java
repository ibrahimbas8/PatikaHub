package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int[] list = {15,12,788,1,-1,-778,2,0};
        System.out.println("Dizi: " + Arrays.toString(list));

        System.out.println("");
        Scanner input = new Scanner(System.in);

        System.out.print("Girilen sayı : ");
        int aranan = input.nextInt();
        input.close();

        int min = aranan;
        int max = aranan;

        for(int i:list){
            if (aranan<i){
                if (max>i || aranan == max){
                    max = i;
                }
            }
            if(aranan>i || aranan < min){

                if (min<i){
                    min = i;
                }
            }
        }
        System.out.println(max);
        System.out.println(min);
    }
}
