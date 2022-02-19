using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MyTool_SpriteSheetTool
{
	public partial class Form1 : Form
	{
		// Form1のコンストラクタ
		public Form1()
		{
			InitializeComponent();
		}

		// 起動時に実行
		private void Form1_Load(object sender, EventArgs e)
		{
			// PictureBoxにドラッグ＆ドロップを許可
			pbDraw.AllowDrop = true;

			// 初期化
			lblPicNumber.Text = "-";
			lblPicSize.Text = "-";

			// フォーカスを外す
			this.ActiveControl = this.panel1;
		}

		//******************************//
		//		　　 　変数　	　			//
		//******************************//

		string sSourcePath;
		string sOutputPath;
		List<string> lSourcePaths;
		int iSourceNum;	// 読み込んだ画像の枚数
		int iSourceW;	// 読み込んだ画像のヨコサイズ
		int iSourceH;   // 読み込んだ画像のタテサイズ
		int iOutputW;	// 出力するヨコサイズ
		int iOutputH;	// 出力するタテサイズ
		int iLayoutCnt;	// 横に並べる枚数
		int iSplitW;	// ヨコの分割数
		int iSplitH;	// タテの分割数
		
		//******************************//
		//		　　 メソッド	　			//
		//******************************//

		// 分割した画像の出力
		private void OutputDividedPictures()
		{
			// テキストボックスの値が不正じゃないかチェック
			try
			{
				iSplitW = int.Parse(tbSplitW.Text);
				iSplitH = int.Parse(tbSplitH.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("「ヨコの分割数」「タテの分割数」には整数の値を入力してください");
				return;
			}
			if (iSplitW <= 0 || iSplitH <= 0)
			{
				MessageBox.Show("「ヨコの分割数」「タテの分割数」には１以上の値を入力してください");
				return;
			}

			// 分割した１枚の画像の出力サイズを決定
			// 整数動詞の割り算　※割り切れない場合の対処無し（ユーザー任せ）
			iOutputW = iSourceW / iSplitW;
			iOutputH = iSourceH / iSplitH;

			// ゼロパディング対応処理（ToStringで使用）
			int len = iSplitW * iSplitH;
			len = len.ToString().Length;
			string sPadding = "";
			for (int i = 0; i < len; i++)
			{
				sPadding += "0";
			}

			// 出力先フォルダを作成
			Directory.CreateDirectory(sOutputPath);

			// 画像を読み込む
			Bitmap bmpBase = new Bitmap(sSourcePath);

			// 画像ファイル名末尾の連番用
			int num = 0;

			// 画像を分割して保存
			for (int ih = 0; ih < iSplitH; ih++)
			{
				for (int iw = 0; iw < iSplitW; iw++)
				{
					// 画像ファイル名末尾の連番用に更新
					num++;

					// 切り抜く座標を更新
					int posW = iOutputW * iw;
					int posH = iOutputH * ih;

					// 画像を切り抜く
					Rectangle rect = new Rectangle(posW, posH, iOutputW, iOutputH);
					Bitmap bmpNew = bmpBase.Clone(rect, bmpBase.PixelFormat);

					// 画像をBMP形式で保存
					if (rbPNG.Checked)
					{
						string newFilePath = sOutputPath + @"\image_" + num.ToString(sPadding) + ".png";
						bmpNew.Save(newFilePath, ImageFormat.Png);
					}
					else if (rbTIFF.Checked)
					{
						string newFilePath = sOutputPath + @"\image_" + num.ToString(sPadding) + ".tiff";
						bmpNew.Save(newFilePath, ImageFormat.Tiff);
					}
					else
					{
						string newFilePath = sOutputPath + @"\image_" + num.ToString(sPadding) + ".bmp";
						bmpNew.Save(newFilePath, ImageFormat.Bmp);
					}

					// リソース解放
					bmpNew.Dispose();
				}
			}

			// リソース解放
			bmpBase.Dispose();
		}

		// 分割した画像の出力
		private void OutputMergedPictures()
		{
			// テキストボックスの値が不正じゃないかチェック
			try
			{
				iLayoutCnt = int.Parse(tbLayoutW.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("「ヨコに並べる数」には整数の値を入力してください");
				return;
			}
			if (iLayoutCnt <= 0)
			{
				MessageBox.Show("「ヨコに並べる数」には１以上の値を入力してください");
				return;
			}

			// 出力先フォルダを作成
			Directory.CreateDirectory(sOutputPath);

			// 出力サイズを決定
			iOutputW = iSourceW * iLayoutCnt;

			int iNumH = iSourceNum / iLayoutCnt;
			int iDev = iSourceNum % iLayoutCnt;
			if (iDev >= 1)
			{
				iNumH += 1;
			}

			iOutputH = iSourceH * iNumH;

			// Listからの指定用
			int num = 0;

			// 画像を読み込む
			Bitmap bmpBase = new Bitmap(iOutputW, iOutputH);
			Graphics g = Graphics.FromImage(bmpBase);

			for (int ih = 0; ih < iNumH; ih++)
			{
				for (int iw = 0; iw < iLayoutCnt; iw++)
				{
					// Listからの指定用に更新
					num++;

					// 結合する座標を更新
					int posW = iSourceW * iw;
					int posH = iSourceH * ih;

					// 範囲外の処理対応
					try
					{
						Image img = Image.FromFile(lSourcePaths[num - 1]);
						g.DrawImage(img, new Point(posW, posH));

						// リソース解放
						img.Dispose();
					}
					catch (Exception)
					{
						// 何もしない（スキップする）
					}
				}
			}

			// リソース解放
			g.Dispose();

			// 画像をBMP形式で保存
			if (rbPNG.Checked)
			{
				string newFilePath = sOutputPath + @"\image" + ".png";
				bmpBase.Save(newFilePath, ImageFormat.Png);
			}
			else if (rbTIFF.Checked)
			{
				string newFilePath = sOutputPath + @"\image" + ".tiff";
				bmpBase.Save(newFilePath, ImageFormat.Tiff);
			}
			else
			{
				string newFilePath = sOutputPath + @"\image" + ".bmp";
				bmpBase.Save(newFilePath, ImageFormat.Bmp);
			}

			// リソース解放
			bmpBase.Dispose();
		}

		//******************************//
		//		　　 イベント	　			//
		//******************************//

		// PictureBoxへのドラッグ
		private void pbDraw_DragEnter(object sender, DragEventArgs e)
		{
			// ドラッグされたデータ形式がファイルかどうか判定
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// ファイルなら受け付ける
				e.Effect = DragDropEffects.All;
			}
			else
			{
				// ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
			}
		}
		// PictureBoxへのドロップ
		private void pbDraw_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				// ドロップした画像のファイルパスを配列に格納
				string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);

				// 画像の数をカウント
				iSourceNum = filePath.Length;

				// 画像が１枚の場合
				if (iSourceNum == 1)
				{
					// パスを変数に格納
					sSourcePath = filePath[0];
					// 出力パスに格納
					sOutputPath = Path.GetDirectoryName(sSourcePath) + @"\Output";

					// 画像を取得
					Bitmap bmap = new Bitmap(sSourcePath);
					Image img = new Bitmap(bmap);
					bmap.Dispose();

					// 表示を更新
					lblPicNumber.Text = "1";
					lblPicSize.Text = img.Width + " x " + img.Height;

					// 画像サイズを変数に格納
					iSourceW = img.Width;
					iSourceH = img.Height;

					// PixtureBoxに表示
					pbDraw.Image = img;
				}
				// 画像が複数枚の場合
				else
				{
					// 名前順に並び替える
					Array.Sort(filePath);
					// List に変換
					lSourcePaths = new List<string>(filePath);

					// パスを変数に格納
					sSourcePath = filePath[0];
					// 出力パスに格納
					sOutputPath = Path.GetDirectoryName(sSourcePath) + @"\Output";

					// 画像を取得
					Bitmap bmap = new Bitmap(sSourcePath);
					Image img = new Bitmap(bmap);
					bmap.Dispose();

					// 表示を更新
					lblPicNumber.Text = filePath.Length.ToString();
					lblPicSize.Text = img.Width + " x " + img.Height;

					// 画像サイズを変数に格納
					iSourceW = img.Width;
					iSourceH = img.Height;

					// PixtureBoxのリソース解放と表示のリセット
					if (pbDraw.Image != null)
					{
						pbDraw.Image.Dispose();
						pbDraw.Image = null;
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show(
						"ドラッグ＆ドロップに失敗しました\r\n" +
						"BMP, JPG, GIF, PNG, TIFF が対応形式です");
			}
		}

		// 出力ボタンを押した時
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (lblPicNumber.Text == "1")
			{
				OutputDividedPictures();
			}
			else
			{
				OutputMergedPictures();
			}
		}

		// 値の入力
		private void tbLayoutW_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Enterキーでビープ音が鳴らないようにして選択状態にする
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;

				tbLayoutW.SelectAll();
			}
		}
		private void tbSplitW_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Enterキーでビープ音が鳴らないようにして選択状態にする
			if (e.KeyChar == (char)Keys.Enter)
			{
				tbSplitW.SelectAll();
			}
		}
		private void tbSplitH_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Enterキーでビープ音が鳴らないようにして選択状態にする
			if (e.KeyChar == (char)Keys.Enter)
			{
				tbSplitH.SelectAll();
			}
		}

		// アクティブになったら選択状態
		private void tbLayoutW_Enter(object sender, EventArgs e)
		{
			tbLayoutW.SelectAll();
		}
		private void tbSplitW_Enter(object sender, EventArgs e)
		{
			tbSplitW.SelectAll();
		}
		private void tbSplitH_Enter(object sender, EventArgs e)
		{
			tbSplitH.SelectAll();
		}
		}
}
