   M S B A M L   `   `   `  ����W  STrabajo_Practico_Consultorio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Trabajo_Practico_ConsultorioTrabajo_Practico_Consultorio  5   	   -    'Trabajo_Practico_Consultorio.Atenciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Trabajo_Practico_Consultorio     5   	     � Title$  
Atenciones��5   	   $��466.433��6   $��1032.584��6-   ���	#FF8080E6.��5	      � .+�5
   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 	dpInicial��5
      $
��Left=�6(   $��
170,28,0,0q�6C   $	��Top=�6W     5   
   -   5        $ dpFinal��5      $
��Left=�6&   $��
549,28,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ cmbConsulta��5      $
��Left=�6(   $��170,130,0,0q�6C   $	��Top=�6X   $	��149��6p   $��27��6|   �� 5   
   -   5        $ cmbDiagnostico��5      $
��Left=�6+   $��170,177,0,0q�6F   $	��Top=�6[   $	��149��6s   $��31��6   �� 5   
   -   5        $ cmbPacientes��5      $
��Left=�6)   $��
170,74,0,0q�6D   $	��Top=�6X   $	��149��6p   $��29��6|   �� 5   
   -   5        $ cmbPlan��5      $
��Left=�6$   $��
576,74,0,0q�6?   $	��Top=�6S   $	��165��6k   $��29��6w   �� 5   
   -   5         ��Name$ lblPaciente��5      $��Paciente��6%   $
��Left=�68   $��	63,77,0,0q�6S   $	��Top=�6f   $��26��6~   $��81��6�   �� 5   
   -   5        $ lblDiagnostico��5      $��Diagnóstico��6(   $
��Left=�6>   $��
45,183,0,0q�6Y   $	��Top=�6m   $��25��6�   $��99��6�   �� 5   
   -	   5        $ 	lblMotivo��5      $��Motivo de consulta��6#   $
��Left=�6@   $��
31,133,0,0q�6[   $	��Top=�6o   $��25��6�   $	��113��6�   �� 5   
   -
   5        $ lblPlan��5      $��Plan terapeutico��6!   $
��Left=�6<   $��
430,80,0,0q�6W   $	��Top=�6k    J� RenderTransformOrigin$ 0.512,0.544&�6�   $��28��6�   $	��108��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.182Q�6&   T� 5       T� X$ 0.004Q�6)    T� Y$ -0.002Q�63   5      5      �� 5   
   -   5        $ cmbRevisiones��5      $
��Left=�6*   $��576,177,0,0q�6E   $	��Top=�6Z   $	��149��6r   $��27��6~   �� 5   
   -   5        $ cmbObservaciones��5      $
��Left=�6-   $��576,130,0,0q�6H   $	��Top=�6]   $	��149��6u   $��27��6�   $ 0.485,0.429&�6�   �� 5   
   -   5        $ lblRevision��5      $��Revision Medica��6%   $
��Left=�6?   $��421,185,0,0q�6Z   $	��Top=�6o   $ 0.5,0.5&�6�   $��28��6�   $	��119��6�   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$      $ -0.182Q�6&   T� 5%      5&      5(      �� 5)   
   -   5        $ lblObservaciones��5)      $��Observaciones��6*   $
��Left=�6B   $��420,136,0,0q�6]   $	��Top=�6r   $ 0.5,0.5&�6�   $��28��6�   $	��117��6�   z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.      $ -0.182Q�6&   T� 5/      50      52      �� 53   
   -   5        $ lblFechaInicial��53      $��Fecha inicial��6)   $
��Left=�6A   $��	63,34,0,0q�6\   $	��Top=�6o   �� 54   
   -   5        $ lblFechaFinal��54      $��Fecha Final��6'   $
��Left=�6=   $��
455,28,0,0q�6X   $	��Top=�6l   &   System.Windows.Controls.DataGrid  55   
   $
��Left=�6   $	��168��6.   $��
31,234,0,0q�6;   $	��Top=�6O   $	��971��6g   ���	#FF94E08C6s   56      57      