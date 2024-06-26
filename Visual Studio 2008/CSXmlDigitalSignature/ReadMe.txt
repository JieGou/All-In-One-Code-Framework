﻿========================================================================
    WINDOWS APPLICATION : CSXmlDigitalSignature Project Overview
========================================================================

/////////////////////////////////////////////////////////////////////////////
Use:

Digital Signatures:

We take the original message and create a message digest by applying the hash
algorithm on the message. The message digest is then encrypted using the 
private key known only to the private key owner (i.e., the sender).The signed
message is formed by concatenating the original message with the unique 
digital signature and the public key that is associated with the private key 
that produced that signature. This entire signed message is then sent to the 
desired recipient.

The received signed message is broken into its three components: the original
message, the public key, and the digital signature. For comparison against 
the hash of the original message, it is necessary to compute the hash of the 
received message. If the message digest has not changed, then you can be very
confident that the message itself has not changed. On the other hand, if the
message digest has changed, then you can be quite certain that the received 
message has been corrupted or tampered with.

CSDigitalSignature demonstrates how to use .NET built-in classes to implement 
Digital Signature for Xml documents.


/////////////////////////////////////////////////////////////////////////////
Code Logic:

Use .NET built-in classes to implement XML digital signature.

A. Creates a cryptographic provider object which supplies public/private
   key pair.
B. Uses the private key to sign an entire XML document.
C. Attaches the signature to the document in <Signature> element.
D. Uses the public key to verify the digital signature


/////////////////////////////////////////////////////////////////////////////
References:

.NET Security and Cryptography 
http://www.amazon.com/Security-Cryptography-Integrated-Object-Innovations/dp/013100851X

RSACryptoServiceProvider Class
http://msdn.microsoft.com/en-us/library/system.security.cryptography.rsacryptoserviceprovider.aspx

Cryptography in .NET
http://www.developer.com/net/net/article.php/1548761

DSACryptoServiceProvider Class
http://msdn.microsoft.com/en-us/library/system.security.cryptography.dsacryptoserviceprovider.aspx

Cryptography in Microsoft.NET Part I: Encryption
http://www.c-sharpcorner.com/UploadFile/gsparamasivam/CryptEncryption11282005061028AM/CryptEncryption.aspx

Cryptography in Microsoft.NET Part II: Digital Envelop and Digital Signatures
http://www.c-sharpcorner.com/UploadFile/Gowri%20S%20Paramasivam/Cryptography211242005003308AM/Cryptography2.aspx


/////////////////////////////////////////////////////////////////////////////
