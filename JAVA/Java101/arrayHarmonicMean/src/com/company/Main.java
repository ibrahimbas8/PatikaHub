package com.company;

public class Main {

    public static void main(String[] args) {
        int[] numbers = {1, 2, 3, 4, 5,33};
        double harmoic = 0;
        for (int i = 1; i < numbers.length+1; i++) {
            for (int j=i; j>0; j--){
                harmoic += (1.0/j);
            }
            System.out.println(i + ". sayının harmonik ortalması : " + harmoic + " ");
            harmoic = 0;
        }


    }
}
