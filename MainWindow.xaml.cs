using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mp4Utl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            { 
            MessageBoxResult Result = MessageBox.Show("上書き保存は､きちんと済ませましたか?\r\n※保存していても､していなくても､最終チェックをぬかしてはいけません!!", "確認", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if(Result == MessageBoxResult.Yes) 
                {
                    MessageBox.Show("では､また会えるのを楽しみに待ってますね!\r\n……へんたいふしんしゃさん♪", "確認");
                    this.Close();
                } else if(Result == MessageBoxResult.No)
                {
                    MessageBox.Show("まったくもう…\r\nこまめな保存は､とても大事です!!\r\nよ～く肝に銘じておいてくださいね!!!!", "確認");
                }
            }

        }
    

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("バージョン：α4\r\n作者：くるみ白羽\r\n\r\nこのソフトウェアは [GNU Lesser General Public License] ライセンスに基づき配布されています｡", "バージョン情報");
        }
    }
}
