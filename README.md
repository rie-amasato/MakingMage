# MakingMage
Make Mage Program for Python3

既存の壁を伸ばす壁伸ばし法を用いた迷路生成プログラム。
N×Nの正方形の迷路を生成してスタート、ゴールを設置します。

# DEMO
生成された20×20の迷路の例  
![Mage](https://user-images.githubusercontent.com/51439946/92684313-215f4580-f370-11ea-8764-8f233a5b0d99.jpg)

# Requirement
numpy  
random  
PIL  

# Usage for python  
pip install git+https://github.com/Yumi-Amahane/MakingMage  
でインストールできます  
import MakingMage  
MakingMage.Mage(int N,str Title)  
  
N×Nの大きさの2次元配列内で迷路を生成
引数Titleが渡されているとき、Title.jpgという名前の生成した迷路を画像出力します  
(Titleは-1以外)  
出力配列では0が地面、2が壁、3,4がスタート、ゴールになっています 
  
# Usage for Unity  
mkdangeon.cs  
mkMage(int N)  
でN平方の迷路配列を生成  
必要に応じてGetComponentで拾う  
