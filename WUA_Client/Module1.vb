

Module Module1

    Sub Main()
        Updates2()

    End Sub


    Private Sub Updates2()
        Dim Us As New WUApiLib.UpdateSession
        Dim rebootinfo As New WUApiLib.SystemInformation
        Dim Updates As New WUApiLib.UpdateCollection
        Dim patch, update, progress, progresstbd, progresstbd1
        Dim test As VariantType
        Dim download As New WUApiLib.UpdateDownloader
        Dim usearch As New WUApiLib.UpdateSearcher
        Dim usjob As WUApiLib.ISearchJob
        Dim downloadjob As WUApiLib.IDownloadJob
        Dim downloadprogress As WUApiLib.IDownloadProgress
        Dim installprogress As WUApiLib.IInstallationProgress
        Dim usresult As WUApiLib.ISearchResult
        Dim Installer As New WUApiLib.UpdateInstaller
        Dim Installerjob As WUApiLib.IInstallationJob



        'Async Suche starten
        usjob = usearch.BeginSearch("IsInstalled=0 and Type='Software'", AsyncCallback(), test)



        'Wärend Job noch nicht fertig ist, Processing ausgeben (TEMP!)
        While Not usjob.IsCompleted
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("Suche nach Updates ...")
        End While

        'Wenn suche fertig, ergebnis an usresult übergeben
        usresult = usearch.EndSearch(usjob)

        'Anzeigen von gefunden Updates
        For I = 0 To usresult.Updates.Count - 1
            update = usresult.Updates.Item(I)
            Console.WriteLine(I + 1 & "> " & update.Title)
        Next

        'Falls keine gefunden wurden, Ausgabe
        If usresult.Updates.Count = 0 Then
            Console.WriteLine("Es sind keine Updates verfügbar")
            Console.WriteLine("Neustart benötigt? : " & rebootinfo.RebootRequired)
            Exit Sub
        End If

        'Gefundene Updates der Update Kollektion hinzufügen
        For a = 0 To usresult.Updates.Count - 1
            patch = usresult.Updates.Item(a)
            Updates.Add(patch)
        Next


        'Charging ma Laz0rs!
        download.Updates = Updates
        downloadjob = download.BeginDownload(downloadprogresss(), downloadcomplete(), test)
        While Not downloadjob.IsCompleted
            System.Threading.Thread.Sleep(2000)
            downloadprogress = downloadjob.GetProgress()
            progress = downloadprogress.PercentComplete
            progresstbd = downloadprogress.TotalBytesDownloaded
            progresstbd1 = Math.Round(progresstbd / 1024 / 1024)
            Console.WriteLine("###################################################################")
            Console.WriteLine("Progress: " & progress & "%")
            Console.WriteLine("Downloaded: " & progresstbd1 & " MB")
        End While
        download.EndDownload(downloadjob)

        'Fehlgeschlagene Downloads aus der Kollektion entfernen
        For a = Updates.Count - 1 To 0 Step -1
            patch = Updates.Item(a)
            If patch.IsDownloaded = False Then
                Console.WriteLine("Failed to download: " & patch.Title)
                Updates.RemoveAt(a)
            End If
        Next

        'Ausgabe über Fertige Updatedownloads
        Console.WriteLine("Patches Downloaded and Available to Install:")
        For a = 0 To Updates.Count - 1
            patch = Updates.Item(a)
            Console.WriteLine(a + 1 & ": " & patch.Title)
        Next


        Installer.Updates = Updates

        Installerjob = Installer.BeginInstall(downloadprogresss, downloadcomplete, test)
        While Not Installerjob.IsCompleted
            System.Threading.Thread.Sleep(2000)
            installprogress = Installerjob.GetProgress()
            Console.WriteLine("###################################################################")
            Console.WriteLine("Installiere Update " & installprogress.CurrentUpdateIndex + 1 & " von " & Updates.Count)
            Console.WriteLine("Aktuelles Update: " & installprogress.CurrentUpdatePercentComplete & "%")
            Console.WriteLine("Gesamtprogress : " & installprogress.PercentComplete & "%")
        End While

        Installer.EndInstall(Installerjob)



        Console.WriteLine("Neustart benötigt? : " & rebootinfo.RebootRequired)
    End Sub

    Private Function AsyncCallback() As Object
        Return 1
    End Function

    Private Function downloadprogresss() As Object
        Return 1
    End Function

    Private Function downloadcomplete() As Object
        Return 1
    End Function



End Module

