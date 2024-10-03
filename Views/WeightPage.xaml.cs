using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceAndWeightConverter.Views;

public partial class WeightPage : ContentPage
{
    
    private double KeyValue = 0;
    
    private double dbl_p2oz = 16;
    private double dbl_p2p = 1;
    private double dbl_p2g = 453.592;
    private double dbl_p2kg = 0.453592;
    private double dbl_p2t = 0.0005;
    
    public WeightPage()
    {
        
        
        InitializeComponent();
        Title = "Weight Converter";

        
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtPound.Text = "";
        txtOunce.Text = "";
        txtGram.Text = "";
        txtKilogram.Text = "";
        txtTon.Text = "";
        
    }
    
    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtPound.Text = (KeyValue * dbl_p2p).ToString("g9");
        txtOunce.Text = (KeyValue * dbl_p2oz).ToString("g9");
        txtGram.Text = (KeyValue * dbl_p2g).ToString("g9");
        txtKilogram.Text = (KeyValue * dbl_p2kg).ToString("g9");
        txtTon.Text = (KeyValue * dbl_p2t).ToString("g9");
    }

    private void TxtOunce_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2oz
        double dblNumber;
        var isvalid = Double.TryParse(txtOunce.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2oz;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtGram_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2i
        double dblNumber;
        var isvalid = Double.TryParse(txtGram.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilogram_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2f
        double dblNumber;
        var isvalid = Double.TryParse(txtKilogram.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2kg;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtTon_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2t
        double dblNumber;
        var isvalid = Double.TryParse(txtTon.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2t;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtPound_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2p
        double dblNumber;
        var isvalid = Double.TryParse(txtPound.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2p;
        }
        else
        {
            KeyValue = 0;
        }
    }

}