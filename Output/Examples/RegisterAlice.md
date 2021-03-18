
Alice registers the callsign alice it has the canonical form
alice.

~~~~
{
  "Callsign":{
    "Id":"alice",
    "Presentation":"alice",
    "Holder":"MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
    "Service":"provisional"}}
~~~~

The registrar receives the request and forwards it to the registry which creates a 
registration record that is enrolled in the callsign log:


~~~~
{
  "Registration":{
    "Id":"NATN-IJI4-IAVS-Z646-CBHQ-MAOI-CWPS",
    "Entry":[{
        "dig":"S512"},
      "ewogICJDYWxsc2lnbiI6IHsKICAgICJJZCI6ICJhbGljZSIsCiAgICAiUH
  Jlc2VudGF0aW9uIjogImFsaWNlIiwKICAgICJIb2xkZXIiOiAiTUJIUy1FS05BLTd
  FSlotVk1VUS1ISTVVLTRGSDMtUlYzVCIsCiAgICAiU2VydmljZSI6ICJwcm92aXNp
  b25hbCJ9fQ",
      {
        "signatures":[{
            "alg":"S512",
            "kid":"MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
            "signature":"EeTMZx7MAVskcP87n7bj3yz9ukgGs22etareDWrf
  jBSmtcbv3p6zYuamKlVrgO3LdHpC7TDNLcuAEBc2OMj2ycTj_blGkAX9sw1RuUREy
  M4S3HV0g-PUwSzDFkBItBKMpE0nVKq35d8SehWdA9CSCDMA"}
          ],
        "PayloadDigest":"IKtQPyuBxPdM81GeFEMCsTK1WG4xyp_xsI3yUjyu
  URfIIAGgYVh0JVd5M59V742SHthSC5abV30gCu3W4q6_FA"}
      ],
    "Submitted":"2021-03-18T01:58:11Z",
    "Reason":"Initial"}}
~~~~
