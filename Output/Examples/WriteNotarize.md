
The first time that the Mesh service provider provisional 
requests Notarization by the Registry, it creates a witness token on its local log:

~~~~
{
  "Id": "provisional",
  "Issuer": "provisional",
  "Apex": "z4PhNX7vuL3xVChQ1m2AB9Yg5AULVxXcg_SpIdNs6c5H0NE8XYXysP
  -DGNKHfuwvY7kxvUdBeoGlODJ6-SfaPg"}
~~~~

The witness value is signed by provisional to create 
a Notarization of the witness value:

~~~~
{
  "Entries": [[{
        "dig": "S512"},
      "ewogICJXaXRuZXNzIjogewogICAgIklkIjogInByb3Zpc2lvbmFsIiw
  KICAgICJJc3N1ZXIiOiAicHJvdmlzaW9uYWwiLAogICAgIkFwZXgiOiAiejRQa
  E5YN3Z1TDN4VkNoUTFtMkFCOVlnNUFVTFZ4WGNnX1NwSWROczZjNUgwTkU4WFl
  YeXNQCiAgLURHTktIZnV3dlk3a3h2VWRCZW9HbE9ESjYtU2ZhUGcifX0",
      {
        "signatures": [{
            "alg": "S512",
            "kid": "MAG2-SFGU-YIE3-YY56-CFQQ-XE52-XOWA",
            "signature": "uGmMvEKz73JsGPP91MktmumFeOgx_plUqtvn5P4Xf396XVuBR
  l7gdmJsdOq4_UUFo8jM222XNcUA4HlzN0OZU9jcOKi7svesib__jnM2mjuiLrx
  2dQImPKquw7_VLOlxeNsfwttixS3iRKbZQrpswxkA"}],
        "PayloadDigest": "J9_gKXKo_Q7JWwc2IvoNt23Sb6oF3HWYpCQosAWflDcCS
  rsfMxIsSNmpkQmIpRsFGoItTK-5TDhXIEV3MTCN6w"}]]}
~~~~

The Notarization value is sent to the registry which enrolls the Notarization in its local
log, creates a Witness value on the entry containing the provider Notarization, and returns
its own Notarization token containing the Witness value it has most recently created.

The next time that the service provider requests Notarization, it creates a Witness token as 
before and includes a Proof path to the previous token:

~~~~
{
  "Entries": [[{
        "dig": "S512"},
      "ewogICJXaXRuZXNzIjogewogICAgIklkIjogInByb3Zpc2lvbmFsIiw
  KICAgICJJc3N1ZXIiOiAicHJvdmlzaW9uYWwiLAogICAgIkFwZXgiOiAiejRQa
  E5YN3Z1TDN4VkNoUTFtMkFCOVlnNUFVTFZ4WGNnX1NwSWROczZjNUgwTkU4WFl
  YeXNQCiAgLURHTktIZnV3dlk3a3h2VWRCZW9HbE9ESjYtU2ZhUGcifX0",
      {
        "signatures": [{
            "alg": "S512",
            "kid": "MAG2-SFGU-YIE3-YY56-CFQQ-XE52-XOWA",
            "signature": "uGmMvEKz73JsGPP91MktmumFeOgx_plUqtvn5P4Xf396XVuBR
  l7gdmJsdOq4_UUFo8jM222XNcUA4HlzN0OZU9jcOKi7svesib__jnM2mjuiLrx
  2dQImPKquw7_VLOlxeNsfwttixS3iRKbZQrpswxkA"}],
        "PayloadDigest": "J9_gKXKo_Q7JWwc2IvoNt23Sb6oF3HWYpCQosAWflDcCS
  rsfMxIsSNmpkQmIpRsFGoItTK-5TDhXIEV3MTCN6w"}]],
  "Proof": {}}
~~~~

[NB, generation and verification of proof is not currently supported in the reference code]

This time, the Registry verifies the proof path before entering the token.
