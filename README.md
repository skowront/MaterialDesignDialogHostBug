# MaterialDesignDialogHostBug
Repository with trials of solutions to a disappearing popup bug. The popup disappears when an user clicks outside of the application and returns when application is clicked again. This situation occurs only when window topmost property is active, otherwise it works fine.


The solution found in one of the issues on github is:

'''
&lt;materialDesign:DialogHost.Style>
            <Style BasedOn="{StaticResource MaterialDesignEmbeddedDialogHost}" TargetType="{x:Type materialDesign:DialogHost}">
            </Style>
</materialDesign:DialogHost.Style&gt;
'''

This is ultimately suspicious.
