package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("matris satir sayisi giriniz: ");
        int satir = input.nextInt();

        System.out.print("matris sutun sayisi giriniz: ");
        int sutun = input.nextInt();
	    int[][] matris  = new int[satir][sutun];

	    for (int i=0; i<matris.length; i++){
	        for (int j=0; j<matris[0].length; j++){
                System.out.println("matris için değer giriniz: ");
                matris[i][j] = input.nextInt();
            }
        }
        System.out.println("Matris : ");
	    print(matris);

        int[][] matrisTranspoz  = new int[sutun][satir];

        for (int i=0; i<matris.length; i++){
            for (int j=0; j<matris[0].length; j++){
                 matrisTranspoz[j][i]=  matris[i][j];
            }
        }
        System.out.println("Transpoz : ");
        print(matrisTranspoz);
    }
    static public void print(int[][] matris){
        for (int[] i: matris){
            for (int j: i){
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }
}
