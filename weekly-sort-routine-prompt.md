Weekly entertainment-inbox sort for David (david.ira.schwartz@gmail.com). Run unattended; don't ask questions. If something is ambiguous, skip it and list it in your final summary. If the Gmail, Google Drive or Google Docs tools are not available in this session, stop and say exactly which are missing.

GOAL: David emails himself links/names of games, movies, TV shows and bands/music. Move each new one into the right Google Doc list, label the email, and archive it.

1. FIND EMAILS. In Gmail, search `from:me to:me newer_than:9d -in:draft` (page through all results). Also include threads with label Games, Movies, TV or Bands newer_than:9d. The 9-day window overlaps last week's run on purpose; step 3's duplicate check prevents double entries. Never process anything older than 2026-10-01.

2. CLASSIFY each thread (read the body with get_thread PLAIN_TEXT if the subject/snippet isn't enough; resolve share.google/X links via https://www.google.com/share.google?q=X and search.app links by following the redirect). Categories and Gmail label IDs:
 - Video/board/tabletop game -> label Games (Label_33) -> Game List
 - Movie (incl. documentaries) -> label Movies (Label_7438524968623899202) -> Movie List
 - TV/streaming series -> label TV (Label_6031592876472407930) -> TV List
 - Band/album/song/music video -> label Bands (Label_7) -> _Music_ToSort
 - Anything else (home repair, crafts, family, work, cord-cutting/hardware, receipts, David's own band rehearsals/recordings) -> leave completely untouched.
 If David already put a label on it, trust his label.

3. ADD TO THE DOCS (read the google-workspace skill reference for Docs first; read each doc with read_doc, guard writes with requiredRevisionId, insert highest index first, then re-read and apply links). Before adding, check the doc text and links; skip anything already present.
 - Game List: doc 1wSkeIfQ4dTV_Jp5xAiSP-kE_wYYPyUBxbK4tYhBvUL0
 - Movie List: doc 1Hl7TfK6Ul6eLk6E0hYOtHqjM6FxkAyLeQW7YjFd6sJg
 - TV List: doc 1pZPQFXzu34rEmYPQNwde7l2h0RNhx969awLjNEOb0U4
 Format for these three: a new paragraph "- Title" (leading "- " = wants it; never "+ " which means owned/watched), inserted in alphabetical order inside its section {#}, {A}..{Z} (titles starting with a digit go in {#}; sort ignoring a leading "The"/"A"). In Game List and TV List, a leading "The"/"A" moves to the end like "Finals, The"; in Movie List keep it in front like "The Wave". The title text (not the "- ") is hyperlinked to the article/trailer URL (strip tracking query strings, keep YouTube v=), styled underline + color rgb(0.067,0.333,0.8); if there's no usable link, link to the Gmail thread: https://mail.google.com/mail/?authuser=david.ira.schwartz@gmail.com#all/thread-f:<threadId hex converted to decimal>. Create a missing letter section if needed (bold "{X}" line, blank line between sections). For TV List only, append " [where it streams in the US, free options first, e.g. Tubi (free), Netflix]" after the link, using JustWatch via web search; write "[not streaming in the US right now]" if none.
 - Best-of/ranked list articles go in the "Best-of lists to mine..." block at the top of that doc; articles where the title isn't named go in the "Articles about a ... whose name was not in the email" block; Facebook links with no identifiable title go in the "Facebook video links filed under ..." block as "Facebook video N". (In TV List these block headings start with "From Gmail".)
 - _Music_ToSort: doc 1GJY8xrKxTcmqW0ECJOBnt7Rv3Fy5jjEdyMd0qs7V-aQ. It has three tabs: main (t.0), Facebook (t.xmo3ryk1dl4n), Articles (t.sfkmpckfaxu7). No +/- markers, not alphabetical. Add each item as one linked line ("Artist – Song" or band name) directly under the bold "From Gmail (sorted 2026-10-01)" line at the top of the main tab; Facebook links as "Subject – <url>" under the same heading at the top of the Facebook tab; music news/articles right under the "Articles" title in the Articles tab. Always pass tabId.
 New inserted text inherits neighboring styles, so reset link/underline/color/bold on inserted ranges before applying your own links.

4. GMAIL. For every thread you added (or that was already in a doc): add the matching category label if it lacks it (label_thread), then archive it (unlabel_thread with ["INBOX"]). Never trash, delete, send, mark read/unread, or touch uncategorized threads.

5. VERIFY by re-reading each edited doc (Drive read_file_content), then end with a short summary: counts added per list with titles, threads labeled/archived, and anything skipped or uncertain. If nothing new was found, say so in one line.
