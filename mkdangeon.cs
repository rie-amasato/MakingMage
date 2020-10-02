using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mkdangeon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Text text;
	// Update is called once per frame
	private int N=7;
	int[,] Map=new int[1,1];
	void Update(){
		if(Input.GetKeyDown(KeyCode.A)){
			text.text="";
			Map=mkMage(N);

			for (int x=0;x<N;x+=1){
				for (int y=0;y<N;y+=1){
					text.text+=Map[x,y].ToString()+",";
				}
				text.text+="\n";
			}
		}
		
	}

	int[,] Reset(int N){
		int[,] map=new int[N,N];
		for (int i=0;i<N;i+=1){
			for (int j=0;j<N;j+=1){
				if (i==0 || j==0 || i==N-1 ||j==N-1)map [i,j] = 1;
				else map [i,j] = 0;
			}
		}
		return(map);
	}

	private int[] Sosuu=new int[5]{-11,2,3,5,7};
	int WCheck(int x,int y,int[,] map,int N){
		print("x="+x.ToString()+":y="+y.ToString());
		int CL=1;
		if (Up(x,y,map,N)==true)CL*=Sosuu[1];
		if (Le(x,y,map,N)==true)CL*=Sosuu[2];
		if (Ri(x,y,map,N)==true)CL*=Sosuu[3];
		if (Do(x,y,map,N)==true)CL*=Sosuu[4];
		print(CL);
		return(CL);
	}

	private bool Do(int x ,int y,int[,] map,int L){
		if (L-2<=y || y<=1 ||L-2<=x)return false;
		if(map[x+1,y-1]!=0 || map[x+1,y]!=0 || map[x+1,y+1]!=0
			||map[x+2,y-1]!=0 || map[x+2,y]!=0 || map[x+2,y+1]!=0)return (false);
		return(true);
	}
	private bool Up(int x ,int y,int[,] map,int L){
		if (x<=2 || y<=1 ||L-2<=y)return false;
		if(map[x-1,y-1]!=0 || map[x-1,y]!=0 || map[x-1,y+1]!=0
			||map[x-2,y-1]!=0 || map[x-2,y]!=0 || map[x-2,y+1]!=0)return (false);
		return(true);
	}
	private bool Ri(int x ,int y,int[,] map,int L){
		if (x>=L-2|| x<=1 ||y>=L-2)return (false);
		if(
			map[x,y+1]!=0 || 
			map[x-1,y+1]!=0 || 
			map[x+1,y+1]!=0
			||map[x-1,y+2]!=0 || map[x,y+2]!=0 || map[x+1,y+2]!=0)return (false);
		return(true);
	}
	private bool Le(int x ,int y,int[,] map,int L){
		if (x<=0 || L-2<=x ||y<=1)return (false);
		if(map[x-1,y-1]!=0 || map[x,y-1]!=0 || map[x+1,y-1]!=0
			||map[x-1,y-2]!=0 || map[x,y-2]!=0 || map[x+1,y-2]!=0)return (false);
		return(true);
	}

	public int[,] mkMage(int N){
		int [,] map=Reset(N);
		for (int LIMIT=0;LIMIT<1000;LIMIT+=1){
			int cnt=0;
			for (int i=0;i<N;i+=1){
				for (int j=0;j<N;j+=1){
					//map[i,j]=WCheck(i,j,map,N);
					if (map[i,j]==1){
						if (WCheck(i,j,map,N)==1)map[i,j]=2;
						else cnt+=1;
					}
				}
			}

			if (cnt==0){
				print("BRK");
				break;
			}
			int Wstart=Random.Range(1,cnt+1);
			for (int i=0;i<N;i+=1){
				for (int j=0;j<N;j+=1){
					if (map[i,j]==1){
						if(WCheck(i,j,map,N)!=1)Wstart-=1;
					if (Wstart==0){
						int WVe=WCheck(i,j,map,N);
						int WVeC=0;
						foreach (int V in Sosuu)if (WVe%V==0)WVeC+=1;
						
						int WVeCc=Random.Range(1,WVeC+1);
						if (WVe%2==0){
							WVeCc-=1;
							if (WVeCc==0)map[i-1,j]=1;
						}
						if (WVe%3==0){
							WVeCc-=1;
							if (WVeCc==0)map[i,j-1]=1;
						}
						if (WVe%5==0){
							WVeCc-=1;
							if (WVeCc==0)map[i,j+1]=1;
						}
						if (WVe%7==0){
							WVeCc-=1;
							if (WVeCc==0)map[i+1,j]=1;
						}
					}
					}
				}
			}
		}
		return (map);
	}
}
